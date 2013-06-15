using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace AEIS
{
    class Round
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
private static extern IntPtr CreateRoundRectRgn

(
int nLeftRect, // x-coordinate of upper-left corner
int nTopRect, // y-coordinate of upper-left corner
int nRightRect, // x-coordinate of lower-right corner
int nBottomRect, // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);
		
//function call, it will return the rounded region of the given region
public static System.Drawing.Region GetRoundedRegion(int controlWidth, int controlHeight)
{
    return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 2, controlWidth-2, controlHeight-2, 5, 5));
}

//the following Line of Code will round the edges of C# form
//this.Region = GetRoundedRegion(this.Width, this.Height);
    }
}
