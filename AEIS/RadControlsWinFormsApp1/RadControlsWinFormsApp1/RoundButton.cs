
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AEIS
{

        
    public class RoundButton : Button
       {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(1, 1, 5, 5);
            
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
            }
    }
}

