using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;

namespace AEIS
{
    class Utility
    {
        //MD5 encription method
        public string Encrypt(string input)
        {
            //Enable MD5 criptography
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //create the byte stream for encription
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            //String builder creation
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            //Travesing byte stream
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            //return encripter password
            return password;
        }

        //Image in to byte stream converter
        public byte[] ConvertImageToBytes(Image image)
        {
            //validate image
            if (image != null)
            {
                MemoryStream ms = new MemoryStream();
                using (ms)
                {
                    image.Save(ms, image.RawFormat);
                    ms.Position = 0;
                    byte[] bytes = ms.ToArray();
                    //return converted image -> byte[]
                    return bytes;
                }
            }
            else
            {
                //return nul for empty parameters
                return null;
            }
        }

        //Random code generator
        private static Random random = new Random((int)DateTime.Now.Ticks);
        public string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        //image to <gray,byte> converter
        public Image<Gray, Byte> ImageToGrayByte(Image image)
        {
            Bitmap masterImage = (Bitmap)image;

            // Normalizing it to grayscale
            Image<Gray, Byte> normalizedMasterImage = new Image<Gray, Byte>(masterImage);

            return normalizedMasterImage;
        }

        public Image<Bgr, Byte> ImageToBgrByte(Image image)
        {
            Bitmap bmpImage = new Bitmap(image);
            return new Image<Bgr, Byte>(bmpImage);
        }
    }
}
