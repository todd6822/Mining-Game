using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Movement
    {
        

            public void FpointChanges(out int yReturn, out int xReturn)// this was initially designed to create some randomness in the movement 
            {// of the asteroids but was never used



                Random r1 = new Random();
                int c = r1.Next(1, 3);

                if (c == 1)
                {
                    yReturn = 0;
                    xReturn = 1;
                }
                else if (c == 2)
                {
                    yReturn = 1;
                    xReturn = 0;
                }
                else
                {

                    yReturn = 1;
                    xReturn = 1;
                }




            }



        }
    }


