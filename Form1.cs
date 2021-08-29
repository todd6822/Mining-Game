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


    public partial class Form1 : Form
    {

        //private int moveX = 0;
        //private int moveY = 0;                                                                                                                            

        Random r2 = new Random();
        
        public int asteroid1Deflect;
        public int asteroid2Deflect;// these are my varaibles for the hitbox locations
        public int asteroid3Deflect;
        public int asteroid4Deflect;
        public int asteroid5Deflect;
        public int asteroid6Deflect;
        public int asteroid7Deflect;
        int asteroid1timer = 1;// timers for the asteroid to asteroid collsion, different default values so they don't 
        int asteroid2timer = 2;     // all bounce off the their first contact simultaneously
        int asteroid3timer = 3;
        int asteroid4timer = 4;
        int asteroid5timer = 5;
        int asteroid6timer = 6;
        int asteroid7timer = 7;
        int tractorBeamTimer = 0;
        Colission colissionCheck = new Colission();// this instantiates the Collision class
        int lives = 3;// number of lives
        public int pause = 0;
        public int scoreCounter1 = 0;// score
        public delegate void passScore(int scoreCounter1);// delegate used to pass the score to the score board form
       // public int[] deflectTimer = new int[] { 0, 0, 0, 0, 0, 0, 0 };//
        int[] changesLeft = new int[] { 2, -3, 3, -2, 4, -3, -5 };// these are the direction to the left that each asteroid moves
        




        public Form1()
        {

            InitializeComponent();
            movement.Stop();

            {
                

            }

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }



        private void shipHitBox_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void asteroid1HitBox_Click(object sender, EventArgs e)
        {

        }

        private void asteroid1_Click(object sender, EventArgs e)
        {

        }

        private void asteroid3_Click(object sender, EventArgs e)
        {

        }

        public void asteroid4_Click(object sender, EventArgs e)
        {

        }

        public void asteroid5_Click(object sender, EventArgs e)
        {

        }

        private void asteroid6_Click(object sender, EventArgs e)
        {

        }

        private void asteroid7_Click(object sender, EventArgs e)
        {

        }


        private void movement_Tick(object sender, EventArgs e)
        {
            int Xp1 = particle1.Location.X;//assings a variable for the locations of the particles
            int Yp1 = particle1.Location.Y;

            int Xp2 = particle2.Location.X;
            int Yp2 = particle2.Location.Y;
            particle1.Location = new Point(Xp1, Yp1 + 10);// moves the particle each tick of the timer
            particle2.Location = new Point(Xp2, Yp2 + 10);


            Random particleRand = new Random();

            int randXp1 = particleRand.Next(1, 150);// this block of code resets the starting location of the particles if they go past the bottom of the screen
            int randXp2 = particleRand.Next(300, 500);
            if (Yp1 >= 300)// these if statements make the warp to the top of the screen after it's traveled down the screen
            {
                particle1.Location = new Point(randXp1, 10);
            }
            if (Yp2 >= 300)// these if statements make the warp to the top of the screen after it's traveled down the screen
            
            {
                particle2.Location = new Point(randXp2, 10);
            }


            asteroid1timer++;// timers for asteroid to asteroid collision, thes emake sure the asteroids aren't constantly bumping into each other
            asteroid3timer++;// they increment once per timer cycle
            asteroid2timer++;
            asteroid4timer++;
            asteroid5timer++;
            asteroid6timer++;
            asteroid7timer++;
            tractorBeamTimer++;

            if (tractorBeamTimer<10)
           {
                tractorBeam.Visible = false;// this makes sure that the tractor beam cannot be activated untill it's time
                   // has been incremeneted up to at least 10
           }

            pause++;
            int Xpict = pictureBox1.Location.X;// assignes a varaible  the ship x location
            int Ypict = pictureBox1.Location.Y;// assignes a variable the ship y location
            shipHitBox.Location = new Point((Xpict + 11), (Ypict -1));
            AsteroidMovement aMove = new AsteroidMovement();
            PictureBox[] hitBoxArray = new PictureBox[7] { asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox, asteroid7HitBox, asteroid1HitBox };
            Colission c1 = new Colission();
            Random r1 = new Random();

            if (tractorBeam.Visible == true)// the tractor beam  collsion detection with 
            {// each asteroid, 
                bool a1Colide= colissionCheck.tractorBeamToAsteroid(asteroid1HitBox, tractorBeam);
                if (a1Colide == true)
                {

                    asteroid1.Location = new Point(-100, r1.Next(0,600));
                    
                }
                bool a2Colide = colissionCheck.tractorBeamToAsteroid(asteroid2HitBox, tractorBeam);
                if (a2Colide == true)
                {

                    asteroid2.Location = new Point(-100, r1.Next(0, 600));
                    
                }
                bool a3Colide = colissionCheck.tractorBeamToAsteroid(asteroid3HitBox, tractorBeam);
                if (a3Colide == true)
                {

                    asteroid3.Location = new Point(-100, r1.Next(0, 600));
                   
                }
                bool a4Colide = colissionCheck.tractorBeamToAsteroid(asteroid4HitBox, tractorBeam);
                if (a4Colide == true)
                {

                    asteroid4.Location = new Point(-100, r1.Next(0, 600));
                   

                }
                bool a5Colide = colissionCheck.tractorBeamToAsteroid(asteroid5HitBox, tractorBeam);
                if (a5Colide == true)
                {

                    asteroid5.Location = new Point(-100, r1.Next(0, 600));



                }
                bool a6Colide = colissionCheck.tractorBeamToAsteroid(asteroid6HitBox, tractorBeam);
                if (a6Colide == true)
                {


                    asteroid6.Location = new Point(-100, r1.Next(0, 600));



                }
                bool a7Colide = colissionCheck.tractorBeamToAsteroid(asteroid7HitBox, tractorBeam);
                if (a7Colide == true)
                {

                    asteroid7.Location = new Point(-100, r1.Next(0, 600));


                }

                tractorBeamTimer = 0;

            }

         /*   for (int dTmerInc = 0; dTmerInc <= 6; dTmerInc++)// this is mainly here for testing
            {
                deflectTimer[dTmerInc]++;
            }*/


            int[] deflectArray = new int[] { asteroid1Deflect, asteroid2Deflect, asteroid3Deflect, asteroid4Deflect, asteroid5Deflect, asteroid6Deflect, asteroid7Deflect };
            bool hit = false;
            aMove.asteroidReset(asteroid1, asteroid1HitBox);// these cause my various asteroids to moves
            aMove.asteroidReset(asteroid2, asteroid2HitBox);
            aMove.asteroidReset(asteroid3, asteroid3HitBox);
            aMove.asteroidReset(asteroid4, asteroid4HitBox);
            aMove.asteroidReset(asteroid5, asteroid5HitBox);
            aMove.asteroidReset(asteroid6, asteroid6HitBox);
            aMove.asteroidReset(asteroid7, asteroid7HitBox);
         
            if (asteroid1timer > 10)// the asteroid movement, it never worked or at least the asteroids wouldn't continue moveing
            {                       // in the deflected direction, thes however work.
                asteroid1Deflect = c1.AsteroidToAsteroid(asteroid1HitBox, asteroid7HitBox, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox);
                changesLeft[0] = (changesLeft[0] * asteroid1Deflect);
                asteroid1timer = 0;
            }

            if (asteroid2timer > 10)
            {
                asteroid2Deflect = c1.AsteroidToAsteroid(asteroid2HitBox, asteroid1HitBox, asteroid6HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid7HitBox);
                changesLeft[1] = (changesLeft[1] * asteroid2Deflect);
                asteroid2timer = 6;
            }
            if (asteroid3timer > 10)
            {
                asteroid3Deflect = c1.AsteroidToAsteroid(asteroid3HitBox, asteroid1HitBox, asteroid2HitBox, asteroid7HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox);
                changesLeft[2] = (changesLeft[2] * asteroid3Deflect);
                asteroid3timer = 0;
            }

            if (asteroid4timer > 10)
            {
                asteroid4Deflect = c1.AsteroidToAsteroid(asteroid4HitBox, asteroid1HitBox, asteroid2HitBox, asteroid3HitBox, asteroid7HitBox, asteroid5HitBox, asteroid6HitBox);
                changesLeft[3] = (changesLeft[3] * asteroid4Deflect);
                asteroid4timer = 0;
            }

            if (asteroid5timer > 10)
            {
                asteroid5Deflect = c1.AsteroidToAsteroid(asteroid5HitBox, asteroid1HitBox, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid7HitBox, asteroid6HitBox);
                changesLeft[4] = (changesLeft[4] * asteroid5Deflect);
                asteroid5timer = 0;

            }

            if (asteroid6timer > 10)
            {
                asteroid6Deflect = c1.AsteroidToAsteroid(asteroid6HitBox, asteroid1HitBox, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid7HitBox);
                changesLeft[5] = (changesLeft[5] * asteroid6Deflect);
                asteroid6timer = 3;
            }

            if (asteroid7timer > 10)
            {
                asteroid7Deflect = c1.AsteroidToAsteroid(asteroid7HitBox, asteroid1HitBox, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox);
                changesLeft[6] = (changesLeft[6] * asteroid7Deflect);
                asteroid7timer = 0;
            }




            if (pause > 5)// added a timer to prevent multiple simultaneous collisions

            {
                hit = colissionCheck.ShipToAsteroid(shipHitBox, pictureBox1, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox, asteroid7HitBox, asteroid1HitBox, movement);// this checks for colision every tick of the timer
                                                                                                                                                                                                              //asteroid1Deflect = asteroid1Deflect * colissionCheck.AsteroidToAsteroid(asteroid1HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox, asteroid7HitBox, asteroid2HitBox, movement);//these check for asteroid collision, they will probably be changed to delegates
                pause = 0;
            }


            PictureBox[] asteroidMovement = new PictureBox[] { asteroid1, asteroid2, asteroid3, asteroid4, asteroid5, asteroid6, asteroid7 };

            // int[] changesLeftSwap = new int[7];
            //changesLeftSwap = changesLeft;






            aMove.movingAsteroids(asteroid1, asteroid2, asteroid3, asteroid4, asteroid5, asteroid6, asteroid7, changesLeft, asteroidMovement);// calls the asteroid movement function

            if (lives > 1)
            {
                saveScore.Visible = false;
            }
            movement.Start();// restarts the movement timer
            if (hit == true)// this looks for ship collision, if it's true, it subtracts 1 life every time the hitbox hits something
            {
                lives = lives - 1;
                if (lives == 0)// this ends the game if your lives fall below 0
                {
                    saveScore.Visible = true;
                    saveScore.Enabled = true;
                    movement.Stop();

                    string finalScore = scoreCounter1.ToString();
                    finalScore = "Your Final Score is" + finalScore;
                    MessageBox.Show("You are out of lives.");

                }

            }
            string livesOutput = lives.ToString();// creates a string for output in the lives field out our UI
            remainingLives.Text = livesOutput;// outputs the lives in out lives field
            scoreCounter1 = scoreCounter1 + 1;// every tick of the movement timer adds 1 to your score

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movementKeys(object sender, KeyEventArgs e)
        {
            int Xp1 = particle1.Location.X;// this block of code resets the starting location of the particles if they go past the bottom of the screen
            int Yp1 = particle1.Location.Y;

            int Xp2 = particle2.Location.X;
            int Yp2 = particle2.Location.Y;
            Random particleRand = new Random();

            int randXp1 = particleRand.Next(1, 150);
            int randXp2 = particleRand.Next(200, 600);
            if (Yp1 >= 300)// these for if statements make the ship warp to the other side of the screen if it goes too far
            {
                particle1.Location = new Point(randXp1, 10);
            }
            if (Yp2 >= 300)// these for if statements make the ship warp to the other side of the screen if it goes too far
            {
                particle2.Location = new Point(randXp2,10);
            }

            int Xpict = pictureBox1.Location.X;// finds the location of picture box 1 and lines it's hitbox up with it
            int Ypict = pictureBox1.Location.Y;
            
            bool hit = false;

            if (pictureBox1.Location.X< 0)// these for if statements make the ship warp to the other side of the screen if it goes too far
            {
                pictureBox1.Location = new Point((600),Ypict);

            }
            if (pictureBox1.Location.X > 600)
            {
                pictureBox1.Location = new Point((0), Ypict);

            }
            if (pictureBox1.Location.Y < 0)
            {
                pictureBox1.Location = new Point(Xpict, 400);

            }
            if (pictureBox1.Location.Y >400)
            {
                pictureBox1.Location = new Point(Xpict, 0);

            }
            shipHitBox.Location = new Point((Xpict + 11), (Ypict - 1));
            tractorBeam.Location = new Point((Xpict + 14), (Ypict - 20));
            Colission colissionCheck = new Colission();

            if (e.KeyCode == Keys.W)
            {


                pictureBox1.Top = (pictureBox1.Top - 3);/// this moves our spaceship forward
                Xpict = pictureBox1.Location.X;// assignes the x and y coordiantes of our spaceship to varaible for our colision box
                Ypict = pictureBox1.Location.Y;
                tractorBeam.Location = new Point((Xpict + 14), (Ypict - 20));
                if (pause > 10)// added a timer to prevent multiple simultaneous collisions
                {
                    hit = colissionCheck.ShipToAsteroid(shipHitBox, pictureBox1, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox, asteroid7HitBox, asteroid1HitBox, movement);// this checks for ship colision
                    pause = 0;
                }
                shipHitBox.Location = new Point((Xpict+11), (Ypict - 1));
                scoreCounter1--;
            }
            if (e.KeyCode == Keys.A)
            {

                pictureBox1.Left = (pictureBox1.Left - 3);// this moves our spaceship left

                Xpict = pictureBox1.Location.X;
                Ypict = pictureBox1.Location.Y;
                tractorBeam.Location = new Point((Xpict + 14), (Ypict - 20));
                if (pause > 10)// added a timer to prevent multiple simultaneous collisions
                {
                    {
                        hit = colissionCheck.ShipToAsteroid(shipHitBox, pictureBox1, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox, asteroid7HitBox, asteroid1HitBox, movement);// this checks for ship colision
                        pause = 0;
                    }


                    shipHitBox.Location = new Point((Xpict+11), (Ypict - 1));
                    scoreCounter1--;
                }
            }
            if (e.KeyCode == Keys.D)
            {

                pictureBox1.Left = (pictureBox1.Left + 3);//moves our ship to the right

                Xpict = pictureBox1.Location.X;
                Ypict = pictureBox1.Location.Y;
                tractorBeam.Location = new Point((Xpict + 14), (Ypict -20));

                if (pause > 10)// added a timer to prevent multiple simultaneous collisions
                {
                    {
                        hit = colissionCheck.ShipToAsteroid(shipHitBox, pictureBox1, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox, asteroid7HitBox, asteroid1HitBox, movement);// this checks for ship colision
                        pause = 0;
                    }

                    shipHitBox.Location = new Point((Xpict+11),(Ypict-1));// colision box follows the ship 

                    scoreCounter1--;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBox1.Top = (pictureBox1.Top + 3);// moves the ship back

                Xpict = pictureBox1.Location.X;
                Ypict = pictureBox1.Location.Y;
                tractorBeam.Location = new Point((Xpict + 14), (Ypict - 20));

                if (pause > 10)// added a timer to prevent multiple simultaneous collisions
                {
                    {
                        hit = colissionCheck.ShipToAsteroid(shipHitBox, pictureBox1, asteroid2HitBox, asteroid3HitBox, asteroid4HitBox, asteroid5HitBox, asteroid6HitBox, asteroid7HitBox, asteroid1HitBox, movement);// this checks for ship colision
                        pause = 0;
                    }
                    shipHitBox.Location = new Point((Xpict+11), (Ypict - 1));


                    scoreCounter1--;

                }
            }
            if (e.KeyCode == Keys.Space)
            {
                
                    tractorBeam.Location = new Point((Xpict + 14), (Ypict - 20));// our newest addition it causes rocks hit by it to teleport to a radom
                if (tractorBeamTimer > 10)// point on the screen outside of the payer's field of view, making it look like to destroys them
                {                           // it has a cool down timer so it needs to be used sparingly
                    tractorBeam.Visible = true;
                    
                }
            }

            
        


            if (hit == true)
            {
                lives = lives - 1;// reduces lives by 1 if the ship is hit by an asteroid
               

            }


            {



            }
        }
    

        


        private void pictureBox1_Click_1(object sender, EventArgs pe)
        {
            
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox3_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)// this counter just refreshes the plygon picture boxes so they can form in a random shape
        {

        }

        private void asteroid4HitBox_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            movement.Start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void remainingLives_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void saveScore_Click(object sender, EventArgs e)
        {
            
            
            scoreBoard f2 = new scoreBoard();//opens the score board part of the application (accesses the databse functions and queires)
            
            passScore pas=new passScore(f2.data);
            pas(this.scoreCounter1);
            f2.Show();

        }

        private void movementKeys(object sender, KeyPressEventArgs e)
        {
           


            
        }

        private void movementKeys(object sender, PreviewKeyDownEventArgs e)
        {

        }
        
    }
    
}





