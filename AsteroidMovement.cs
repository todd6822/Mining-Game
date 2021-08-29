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
    class AsteroidMovement
    {
        

        public void movingAsteroids(PictureBox p1, PictureBox p2, PictureBox p3, PictureBox p4, PictureBox p5, PictureBox p6, PictureBox p7, int[] changesLeft, PictureBox[] hitBox)// 
        {
            //assignes the asteroid objects to an array

            PictureBox[] inputArray = new PictureBox[]
            {p1,p2,p3,p4,p5,p6,p7};

            int[] changesTop = new int[] { 5, 4, 3, 2, 4, 3, 4 };// these are the direction changes for our asteroids
            
            
            Colission c1 = new Colission();
            for (int x = 0; x <= 6; x++)
            {  

                PictureBox z = hitBox[x];
                PictureBox a = inputArray[x];// array of picture boxed
               
                
                    a.Top = (a.Top + changesTop[x]);// cycles through the picture boxes and applies the correct movements for each
                    a.Left = (a.Left + (changesLeft[x])) ;
   
            }
            
        }
        public void asteroidReset(PictureBox p1,PictureBox p1CollisionBox)// this function resets the location of the asteroid if it goes off the playable map
            
        {
            Random r1 = new Random();
            
            int Xpict1 = p1.Location.X;
            int Ypict1 = p1.Location.Y;

            if ((Xpict1 >= 550))
            {
                int randomLoc = r1.Next(1, 400);
                p1.Location = new Point(randomLoc, Ypict1);                                                                                                                  
            }
            if (Ypict1 >= 300)
            {
                
                p1.Location = new Point(Xpict1, 1);                    // These line moves the asteroid to a restart point if they reach the end of the map          
            }
            p1CollisionBox.Location = new Point(Xpict1 + 65, Ypict1 + 15);


        }

    }
}
