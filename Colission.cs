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
    class Colission
    {
         public int AsteroidToAsteroid(PictureBox test,// this checks for colision between the "test" asteroid and all others
            PictureBox asteroid1, PictureBox asteroid2, PictureBox asteroid3,
            PictureBox asteroid4, PictureBox asteroid5, PictureBox asteroid6)
        {
            PictureBox[] array1 = new PictureBox[] { asteroid1,asteroid2, asteroid3, asteroid4, asteroid5, asteroid6 };

            

            

            for (int y = 0; y <= 5; y++)// this for loops cycles through each asteroid bounds checking between each one 
            {                               
                PictureBox a=array1[y];
                if (test.Bounds.IntersectsWith(a.Bounds))
                {
                    return -1;
                    
                }
               
            }
            return 1;

    }
        public bool ShipToAsteroid(PictureBox shipHitBox,PictureBox ship, PictureBox asteroid1,
            PictureBox asteroid2,PictureBox asteroid3,PictureBox asteroid4,
            PictureBox asteroid5,PictureBox asteroid6,PictureBox asteroid7, Timer t1)

        {

            bool hit=false;
            PictureBox[] array1 = new PictureBox[] { asteroid1,asteroid2,asteroid3,asteroid4,asteroid5,asteroid6,asteroid7}; 


            for (int x=0; x <= 6;x++ )
            {
                PictureBox a;
                a = array1[x];

               if  (shipHitBox.Bounds.IntersectsWith(a.Bounds))// checks for collsion between the ship and each asteroid 
                {// if there is contact, the ship is teleported to a starting location and a message is displayed
                    t1.Stop();//a bool value is returned
                    MessageBox.Show("Be more careful");
                    ship.Location = new Point(0, 200);
                    int Xship = ship.Location.X;
                    int Yship = ship.Location.Y;
                    shipHitBox.Location = new Point((Xship+11 ), (Yship-1));
                    t1.Start();
                    hit = true;
                }

            }

            return hit;

        }
        public bool tractorBeamToAsteroid(PictureBox asteroid,PictureBox TractorBeam)// checks colision between the tractor beam
        {// and the 1 aserteroid
            bool caught= false;
          if (asteroid.Bounds.IntersectsWith(TractorBeam.Bounds))
            {
                caught = true;
            }

            return caught;
        }
           
            
        }

    }

