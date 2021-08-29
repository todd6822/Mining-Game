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
    class TrianglePictureBox : System.Windows.Forms.PictureBox// this is  my custom picture box shaped like a trianlge
    {

        protected override void OnPaint(PaintEventArgs pe)
        {
            using (var p = new GraphicsPath())
            {

                p.AddPolygon(new Point[]
                    {new Point (this.Width/2,0),
                        new Point(0,Height),
                        new Point(Width,Height) });
                this.Region = new Region(p);
                base.OnPaint(pe);
            }
        }
    }
}
