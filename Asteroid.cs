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
using FileHelpers;

namespace WindowsFormsApplication2
{
}
public class Asteroid
{

    public Point[] AstroRender(int xStart, int yStart)
    {
       System.Drawing.Point[] polygons1 = new System.Drawing.Point[7];// creates an instance of the polygons class
       Random r1 = new Random();                                    // using an array of points





        int point1a = r1.Next(1, 10);// random numbers generated to add variety to the geometry of our polygon
        int point1b = r1.Next(1, 10);
        int point2a = r1.Next(1, 10);
        int point2b = r1.Next(1, 10);
        int point3a = r1.Next(1, 10);
        int point3b = r1.Next(1, 10);
        int point4a = r1.Next(1, 10);
        int point4b = r1.Next(1, 10);
        int point5a = r1.Next(1, 10);
        int point5b = r1.Next(1, 10);
        int point6a = r1.Next(1, 10);
        int point6b = r1.Next(1, 10);
        int point7a = r1.Next(1, 10);
        int point7b = r1.Next(1, 10);

        polygons1[0] = new Point((xStart + 40 + (point1a)), (yStart + 40 + (point1b)));
        polygons1[1] = new Point((xStart+ 60 + (point2a)), (yStart+ 15 + (point2b)));
        polygons1[2] = new Point((xStart+ 80 + (point3a)), (yStart+ 1 + (point3b)));
        polygons1[3] = new Point((xStart+ 90 + (point4a)), (yStart+ 10 + (point4b)));                           // points for our polygon
        polygons1[4] = new Point((xStart+ 100 + (point5a)), (yStart + 15 + (point5b)));
        polygons1[5] = new Point((xStart+ 110 + (point6a)), (yStart + 25 + (point6b)));
        polygons1[6] = new Point((xStart + 80 + (point7a)), (yStart + 50 + (point7b)));



        return polygons1;// returns an array of points
    }
}