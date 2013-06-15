using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using AForge.Math.Geometry;
using System.IO;
using System.Xml;
using OMR;

namespace OMR
{
    public class OpticalReader
    {

        public int getRegNumOfSheet(System.Drawing.Image image, XML.OMREnums.OMRSheet sheet, string OMRSheetFile, bool readInvalidRegNum) //parameters - panel1.BackgroundImage, OMREnums.OMRSheet.A550, "sheets.xml", false
        {
            Rectangle[] Blocks = new Rectangle[] //stores a set of four integers that represent the location & size of a rectangle
            {
                XML.OMRSheetReader.GetSheetPropertyLocation(OMRSheetFile, sheet, XML.OMREnums.OMRProperty.RegNumBlock),
            };

            List<Bitmap[]> bmps = new List<Bitmap[]>(); //list of bitmap objects, bitmap - pixel data for graphics image and its attributes
            bmps.Add(SliceOMarkBlock(image, Blocks[0], 3)); //image = panel1.BackgroundImage, location of reg no block, slices = 3 digits for reg no
            //fill the bitmap array with bitmap images of slice images of reg no block 
            //SliceOMarkBlock method returns 3 sliced bitmap images of reg no block, those bitmap images are added to bmps list

            int regNum = 0, multiplier = 100;
            foreach (Bitmap[] blk in bmps)
            {
                foreach (Bitmap line in blk)//line = line containing numbers from 0 to 9
                {
                    try
                    {
                        int num = rateSlice(line, 10) - 1; //
                        if (num < 1 && !readInvalidRegNum)
                            throw new Exception("Invalid Reg. No.");
                        else
                        {
                            if (num < 0) num = 0;
                            regNum += num * multiplier;
                            multiplier /= 10;
                        }

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Image is too noisy");
                    }


                }
            }


            return regNum;
        }


        public int rateSlice(Bitmap slice, int OMCount) //rateSlice(line, 10) this method is done for each line containing 10 digits
        {
            Rectangle[] cropRects = new Rectangle[OMCount]; //rectangle type array to store 10 elements 
            Bitmap[] marks = new Bitmap[OMCount]; //bitmap type array to store 10 elements 

            //sub-devide line into option (horizontal only)
            for (int i = 0; i < OMCount; i++)
            {
                //take each number as a rectangle and store their location details, 10 rectangles
                cropRects[i] = new Rectangle(i * slice.Width / OMCount, 0, slice.Width / OMCount, slice.Height);

            }

            int crsr = 0;
            foreach (Rectangle cropRect in cropRects)
            {
                Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(slice, new Rectangle(0, 0, target.Width, target.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                }
                marks[crsr] = target; //now we have  bitmap array containing images of each number
                crsr++;
            }
            List<long> fullInks = new List<long>();

            //get marking level
            foreach (Bitmap mark in marks)
            {
                fullInks.Add(InkDarkness(mark));
            }
            int indofMx = -1, indofMn = -1;
            long maxD = 0;

            //get maximum ink level
            for (int i = 0; i < OMCount; i++)
            {
                if (fullInks[i] > maxD)
                {
                    maxD = fullInks[i];
                    indofMx = i;
                }
            }
            bool parallelExist = false, spe = false, tpe = false, fpe = false;
            for (int i = 0; i < OMCount; i++)
            {
                if (i != indofMx)
                {
                    if ((double)fullInks[indofMx] / fullInks[i] <= 2) //both ink levels are nearly the same
                    {
                        if (tpe) fpe = true;
                        if (spe) tpe = true;
                        if (parallelExist) spe = true;
                        parallelExist = true;
                    }
                }
            }
            int negScore = parallelExist ? -1 : 0;
            negScore = spe ? -2 : negScore;
            negScore = tpe ? -3 : negScore;
            negScore = fpe ? -4 : negScore;

            if (!parallelExist)
                return indofMx + 1;
            //check if multiple options were selected
            bool atleastOneUnfilled = false;
            for (int i = 0; i < OMCount; i++)
            {
                if (i != indofMx)
                {
                    if ((double)fullInks[indofMx] / fullInks[i] >= 3)
                        atleastOneUnfilled = true;
                }
            }
            if (atleastOneUnfilled)
                return negScore;


            return 0;
        }
        public long InkDarkness(Bitmap OMark) //get the darkness of each circle area
        {
            int darkestC = 255, lightestC = 0;

            UnmanagedImage mark = UnmanagedImage.FromManagedImage(OMark); //image in unmanaged memory
            for (int y = 0; y < OMark.Height; y++)
                for (int x = 0; x < OMark.Width; x++)
                {
                    Color c = mark.GetPixel(x, y);
                    if (((c.R + c.G + c.B) / 3) > lightestC)
                    {
                        lightestC = ((c.R + c.G + c.B) / 3);
                    }
                    if (((c.R + c.G + c.B) / 3) < darkestC)
                    {
                        darkestC = ((c.R + c.G + c.B) / 3);
                    }
                }
            int dc = 0;
            for (int y = 0; y < OMark.Height; y++)
                for (int x = 0; x < OMark.Width; x++)
                {
                    Color c = mark.GetPixel(x, y);

                    if (((c.R + c.G + c.B) / 3) < (lightestC + darkestC) / 2)
                    { dc += 255; }
                }
            return dc;
        }
        public Bitmap[] SliceOMarkBlock(System.Drawing.Image fullSheet, Rectangle slicer, int slices)
        {
            List<Rectangle> cropRects = new List<Rectangle>(); //list of rectangle objects
            Bitmap[] bmps = new Bitmap[slices];
            for (int i = 0; i < slices; i++)
            {
                cropRects.Add(new Rectangle(slicer.X, slicer.Y + (slicer.Height / slices) * i, slicer.Width, slicer.Height / slices));
            }
            Bitmap src = (Bitmap)fullSheet;
            int crsr = 0;
            foreach (Rectangle cropRect in cropRects)
            {
                Bitmap target = new Bitmap(cropRect.Width, cropRect.Height); //creating a bitmap object for each rectangle in the list

                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                }
                bmps[crsr] = target;
                crsr++;
            }
            return bmps; //array containing the bitmap images of each line in the registration no block
            throw new Exception("Couldn't slice");
        }


    }
}
