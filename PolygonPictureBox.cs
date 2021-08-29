using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    class PolygonPictureBox1 : System.Windows.Forms.PictureBox
    {

        protected override void OnPaint(PaintEventArgs pe)// this is my custom picture box shaped like a 7 pointed polygon
        {
            using (var p = new GraphicsPath())
            {

                System.Drawing.Point[] polygons1 = new System.Drawing.Point[7];// creates a polygon 

                Asteroid C1 = new Asteroid(); // creates a new instance of the asteroid class to create a random polygon

                int xAxis = 0;
                int yAxis = 0;

                polygons1 = C1.AstroRender(xAxis, yAxis);// this class was originally designed to create and image of a polygon on the screeen not a variably shaped picture box, this works however

                p.AddPolygon(polygons1);
                  
                this.Region = new Region(p);
                base.OnPaint(pe);
            }
        }
    }
}
