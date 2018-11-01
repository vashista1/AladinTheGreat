//Name: Vashista Gande
//Date: June 10th, 2016
//Purpose: To make an interactive game using various concepts learnt in this course
//Title: Aladdin The Great
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AladinTheGreat
{
    public partial class MainGame : Form
    {
        //Variable Decleration
        PictureBox picMat;
        PictureBox picScore1;
        PictureBox picScore2;
        PictureBox picScore3;
        PictureBox picLife1;
        PictureBox picLife2;
        PictureBox picLife3;
        PictureBox picJeene;
        PictureBox picBack;
        PictureBox[] picGoldCoin = new PictureBox[6];
        PictureBox[] picRedGoldCoin = new PictureBox[6];
        PictureBox picBoostGoldCoin;        

        static int intDirection = 1;
        static int intSpeed = 10;
        static int intCoinDirection = -1;
        static int intCoinSpeed = 15;        
        static int intCointCounter;
        static int intBadCoinCounter;
        static int intCoinVisibility = -53;
        static int intCoinxValue;
        static int intFast;
        static int intBoost1Interval = 140;

        public static int intScore;
        public static int intLife;
        public static int intGameCounter;

        static bool boolBoostFall = false;
        static bool blnTimer = false;
        static bool boolFast = false;
        static bool blnEasy = LevelSelect.variables;

        public static Random rdCoinxValue = new Random();            

        private enum Direction { None, Left, Right, Up, Down };
        private Direction currentDir = Direction.None;
        
        public MainGame()
        {
            //Starts to put the pictures offscreen when game starts
            InitializeComponent();            
            gameStart();
            
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
        }
        /**********************************************************
        * Name: Vashista Gande
        * Date: June 13th, 2016
        * Description: Makes all the picture arrays for the coins when game is 
        *              initiated
        * ********************************************************/
        public void gameStart()
        {
            //Puts various picutres on the screen
            picMat = new PictureBox();
            picMat.Location = new Point((this.Width / 2)-120, this.Bottom-105);
            picMat.Size = new Size(150, 100);
            picMat.Name = "pictureMat";
            picMat.Image = imgMat.Images[0];
            picMat.BackColor = Color.Transparent;
            Controls.Add(picMat);
            picMat.BringToFront();
            
            score();

            coinFall();
            redCoinFall();
            boostCoinFall();
            

            if (blnEasy == true)
            {
                picJeene = new PictureBox();
                picJeene.Location = new Point((this.Width / 2), this.Bottom - 185);
                picJeene.Size = new Size(50, 80);
                picJeene.Name = "pictureJeene";
                picJeene.Image = Aladdin.Jeene_Left;
                picJeene.BackColor = Color.Transparent;
                Controls.Add(picJeene);
            }
            
            picBack = new PictureBox();
            picBack.Location = new Point(0, 0);
            picBack.Size = new Size(1100,1100);
            picBack.Name = "pictureBack";
            picBack.Image = Aladdin.GameBackGround;
            picBack.BackColor = Color.Transparent;
            Controls.Add(picBack);



        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 10th, 2016
        * Description: Makes actions correspond to key presses
        * ********************************************************/
        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left: currentDir = Direction.Left; break;
                case Keys.Right: currentDir = Direction.Right; break;
            }
        }

        /*************************************************************
        * Name: Vashista Gande
        * Date: June 10th, 2016
        * Description: Timer for only calculating and updating values
        * ***********************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Useed when boost coin is collected
            int vel = 25;
            if(boolFast ==true)
            {
                intFast++;
                vel = 55;
            }
            if(intFast==100)
            {
                intFast = 0;
                intBoost1Interval *= 5;
                boolFast = false;
            }
            
            switch (currentDir)
            {
                case Direction.Left: picMat.Left -= Math.Min(vel, picMat.Left); break;
                case Direction.Right: picMat.Left += Math.Min(vel, this.ClientSize.Width - picMat.Right); break;
            }

            intGameCounter++;
            //starts the game 
            lblScore.Text = "Game Counter:" + intGameCounter;
            if (intGameCounter > 14)
            {
                intCointCounter++;
                
                if (blnEasy == true)
                {
                    //Puts jeene on the screen 
                    picJeene.Left -= intSpeed * intDirection;


                    if (this.picJeene.Left < -50)
                    {
                        picJeene.Image = Aladdin.Jeene_Right;
                        intDirection *= -1;
                    }

                    if (this.picJeene.Left + this.picJeene.Width > 1100)
                    {
                        picJeene.Image = Aladdin.Jeene_Left;
                        intDirection *= -1;
                    }
                }
                //puts other coins on the screen
                drop();
                badDrop();              
                                
                boostDrop();  
            }
            //Disables the timer when the game is over
            if(blnTimer == true)
            {
                timGame.Enabled = false;
                (new GameEnd()).Show();
            }
        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 11th, 2016
        * Description: Results in the position of the Gold Coins
        * ********************************************************/
        public void drop()
        {
            int intTimeCounter = 5;
            if (intCointCounter > intTimeCounter)
            {
                if (blnEasy == true)
                {
                    //gets and sets the location
                    picGoldCoin[0].Top -= intCoinSpeed * intCoinDirection;
                    //gets the direction 
                    if (this.picGoldCoin[0].Top < -54)
                    {
                        intCoinDirection *= 1;
                    }

                    if (this.picGoldCoin[0].Top > 1100)
                    {
                        intCoinDirection *= 1;
                    }
                }
                else if (blnEasy == false)
                {
                    //gets and sets the Y location
                    int Yval = picGoldCoin[0].Location.Y;
                    //Uses function to get new X location
                    double Xval = doSinCalc(Yval);
                    //Assigns new location
                    picGoldCoin[0].Location = new Point((int)Xval, Yval);
                    //Moves it down 
                    picGoldCoin[0].Top += intCoinSpeed;
                }
            }
            if (intCointCounter > (intTimeCounter + 35))
            {
                //gets and sets the location
                picGoldCoin[1].Top -= intCoinSpeed * intCoinDirection;
                //gets the direction 
                if (this.picGoldCoin[1].Top < -54)
                {
                    intCoinDirection *= 1;
                }

                if (this.picGoldCoin[1].Top > 1100)
                {
                    intCoinDirection *= 1;
                }
            }
            if (intCointCounter > (intTimeCounter + 55))
            {
                if (blnEasy == true)
                {
                    //gets and sets the location
                    picGoldCoin[2].Top -= intCoinSpeed * intCoinDirection;
                    //gets the direction 
                    if (this.picGoldCoin[2].Top < -54)
                    {
                        intCoinDirection *= 1;
                    }

                    if (this.picGoldCoin[2].Top > 1100)
                    {
                        intCoinDirection *= 1;
                    }
                }
                else if (blnEasy == false)
                {
                    //gets and sets the Y location
                    int Yval = picGoldCoin[2].Location.Y;
                    //Uses function to get new X location
                    double Xval = doSinCalc(Yval);
                    //Assigns new location
                    picGoldCoin[2].Location = new Point((int)Xval, Yval);
                    //Moves it down 
                    picGoldCoin[2].Top += intCoinSpeed;
                }
            }
            if (intCointCounter > (intTimeCounter + 65))
            {
                //gets and sets the location
                picGoldCoin[3].Top -= intCoinSpeed * intCoinDirection;
                //gets the direction 
                if (this.picGoldCoin[3].Top < -54)
                    {
                        intCoinDirection *= 1;
                    }

                    if (this.picGoldCoin[3].Top > 1100)
                    {
                        intCoinDirection *= 1;
                    }
                
            }     
            //Checks the winner       
            checkWin();
        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 11th, 2016
        * Description: Results in the position of the Red Coins
        * ********************************************************/
        public void badDrop()
        {
            if (intCointCounter > 50)
            {
                intBadCoinCounter++;
                int intBadTimeCounter = 5;//Timer for the fall
                if (intBadCoinCounter > intBadTimeCounter)//Times the fall 
                {
                    //gets and sets the location
                    picRedGoldCoin[0].Top -= intCoinSpeed * intCoinDirection;
                    //gets the direction 
                    if (this.picRedGoldCoin[0].Top < -54)
                    {
                        intCoinDirection *= 1;
                    }

                    if (this.picRedGoldCoin[0].Top > 1100)
                    {
                        intCoinDirection *= 1;
                    }
                }
                if (intBadCoinCounter > (intBadTimeCounter + 35))//Times the fall 
                {
                    //gets and sets the location
                    picRedGoldCoin[1].Top -= intCoinSpeed * intCoinDirection;
                    //gets the direction 
                    if (this.picRedGoldCoin[1].Top < -54)
                    {
                        intCoinDirection *= 1;
                    }

                    if (this.picRedGoldCoin[1].Top > 1100)
                    {
                        intCoinDirection *= 1;
                    }
                }
                if (intBadCoinCounter > (intBadTimeCounter + 55))//Times the fall 
                {
                    //gets and sets the location
                    picRedGoldCoin[2].Top -= intCoinSpeed * intCoinDirection;
                    //gets the direction 
                    if (this.picRedGoldCoin[2].Top < -54)
                    {
                        intCoinDirection *= 1;
                    }

                    if (this.picRedGoldCoin[2].Top > 1100)
                    {
                        intCoinDirection *= 1;
                    }
                }
            }

        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 11th, 2016
        * Description: Results in the position of the Boost Coins
        * ********************************************************/
        public void boostDrop()
        {
            //Times the fall
            if (intGameCounter % intBoost1Interval == 0)
            {
                boolBoostFall = true;
            }
            if(boolBoostFall == true)
            {
                //Gets and sets the location
                picBoostGoldCoin.Top -= intCoinSpeed * intCoinDirection;
                //Gets the direction
                if (this.picBoostGoldCoin.Top < -54)
                {
                    intCoinDirection *= 1;
                }

                if (this.picBoostGoldCoin.Top > 1100)
                {
                    intCoinDirection *= 1;
                }
            }
               
            
        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 11th, 2016
        * Description: Results in the dropping of the Gold Coins
        * ********************************************************/
        public void coinFall()
        {
            //Puts the pictures on the screen
            for (int x = 0; x < 6; x++)
            {
                intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
                picGoldCoin[x] = new PictureBox();
                picGoldCoin[x].Location = new Point(intCoinxValue, intCoinVisibility);
                picGoldCoin[x].Size = new Size(25, 25);
                picGoldCoin[x].Name = "pictureGoldenCoin";
                picGoldCoin[x].Image = imgGoldCoin.Images[0];
                picGoldCoin[x].BackColor = Color.Transparent;
                picGoldCoin[x].BringToFront();
                Controls.Add(picGoldCoin[x]);     
            }
        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 11th, 2016
        * Description: Results in the dropping of the Red Coins
        * ********************************************************/
        public void redCoinFall()
        {
            //Puts the pictures on the screen
            for (int x = 0; x < 6; x++)
            {
                intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
                picRedGoldCoin[x] = new PictureBox();
                picRedGoldCoin[x].Location = new Point(intCoinxValue, intCoinVisibility);
                picRedGoldCoin[x].Size = new Size(25, 25);
                picRedGoldCoin[x].Name = "pictureRedCoin";
                picRedGoldCoin[x].Image = imgBadCoin.Images[0];
                picRedGoldCoin[x].BackColor = Color.Transparent;
                picRedGoldCoin[x].BringToFront();
                Controls.Add(picRedGoldCoin[x]);
            }
        }


        /**********************************************************
        * Name: Vashista Gande
        * Date: June 11th, 2016
        * Description: Results in the dropping of the Boost Coins
        * ********************************************************/
        public void boostCoinFall()
        {
            //Puts the pictures on the screen
            intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
                picBoostGoldCoin = new PictureBox();
                picBoostGoldCoin.Location = new Point(intCoinxValue, intCoinVisibility-50);
                picBoostGoldCoin.Size = new Size(60, 60);
                picBoostGoldCoin.Name = "pictureBoostGoldenCoin";
                picBoostGoldCoin.Image = boostCoin.Images[0];
                picBoostGoldCoin.BackColor = Color.Transparent;
                picBoostGoldCoin.BringToFront();
                Controls.Add(picBoostGoldCoin);
        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 12th, 2016
        * Description: Makes boundaries of the game, when you win, 
        *              and when you lose and also adds score and life
        * ********************************************************/
        public void checkWin()
        {

            for (int x = 0; x < 6; x++)
            {
                //Checks if the coins hit the boundary or the mat or jeene in easy level and give score according to that and takes away the life
                if (blnEasy == true)
                {
                    if ((picGoldCoin[x].Bounds).IntersectsWith(picJeene.Bounds))
                    {
                        intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
                        picGoldCoin[x].Location = new Point(intCoinxValue, intCoinVisibility);
                        intScore++;
                    }
                }
                
                    if ((picGoldCoin[x].Bounds).IntersectsWith(picMat.Bounds))
                    {                       

                        intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
                        picGoldCoin[x].Location = new Point(intCoinxValue, intCoinVisibility);
                        intScore++;                        
                    }
                    else if ((picGoldCoin[x].Bounds).IntersectsWith(picBoxBot.Bounds))
                    {
                        intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
                        picGoldCoin[x].Location = new Point(intCoinxValue, intCoinVisibility);
                    }

                    if ((picRedGoldCoin[x].Bounds).IntersectsWith(picMat.Bounds))
                    {
                        intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
                        picRedGoldCoin[x].Location = new Point(intCoinxValue, intCoinVisibility);
                        intLife++;
                    }
                    else if ((picRedGoldCoin[x].Bounds).IntersectsWith(picBoxBot.Bounds))
                    {
                        intCoinxValue = rdCoinxValue.Next(0, (this.Width - 50));
                        picRedGoldCoin[x].Location = new Point(intCoinxValue, intCoinVisibility);
                    }
                              
            
                int number = intScore;
                if (number >= 10 && number <= 99)
                {
                    int intOnes = number % 10;
                    for (int c = 0; c < 10; c++)
                    {
                        if (intOnes == c)
                        {
                            picScore3.Image = imgScore.Images[c];
                        }
                    }
                    while (number >= 10)
                    {
                        number = (number - (number % 10)) / 10;
                    }
                    for (int c = 0; c < 10; c++)
                    {
                        if (number == c)
                        {
                            picScore2.Image = imgScore.Images[c];
                        }
                    }
                }
                else if (number <10)
                {
                    int intOnes = number % 10;
                    for (int c = 0; c < 10; c++)
                    {
                        if (intOnes == c)
                        {
                            picScore3.Image = imgScore.Images[c];
                        }
                    }
                }
                if(intLife==1)
                {
                    picLife1.Visible = false;
                }
                else if (intLife == 2)
                {
                    picLife2.Visible = false;
                }
                else if (intLife == 3)
                {
                    picLife3.Visible = false;


                    HighScore.scoreWriter();
                    blnTimer = true;             

                }

            }
            boost1Touch();
        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 12th, 2016
        * Description: Creates pictures for score and life on the 
                       game screen and assigns their location
        * ********************************************************/
        public void score()
        {
            //Puts the score pictures and life pictures on the screen
            picScore1 = new PictureBox();
            picScore1.Location = new Point(this.Width-90 , 0);
            picScore1.Size = new Size(30,30);
            picScore1.Name = "pictureMat";
            picScore1.Image = imgScore.Images[0];
            Controls.Add(picScore1);
            picScore1.BringToFront();

            picScore2 = new PictureBox();
            picScore2.Location = new Point(this.Width - 60, 0);
            picScore2.Size = new Size(30, 30);
            picScore2.Name = "pictureMat";
            picScore2.Image = imgScore.Images[0];
            Controls.Add(picScore2);
            picScore2.BringToFront();

            picScore3 = new PictureBox();
            picScore3.Location = new Point(this.Width - 30, 0);
            picScore3.Size = new Size(30, 30);
            picScore3.Name = "pictureMat";
            picScore3.Image = imgScore.Images[0];
            Controls.Add(picScore3);
            picScore3.BringToFront();

            picLife1 = new PictureBox();
            picLife1.Location = new Point(this.Width - 135, 45);
            picLife1.Size = new Size(45, 45);
            picLife1.Name = "pictureLife";
            picLife1.Image = imgLife.Images[0];
            Controls.Add(picLife1);
            picLife1.BringToFront();

            picLife2 = new PictureBox();
            picLife2.Location = new Point(this.Width - 90, 45);
            picLife2.Size = new Size(45, 45);
            picLife2.Name = "pictureLife";
            picLife2.Image = imgLife.Images[0];
            Controls.Add(picLife2);
            picLife2.BringToFront();

            picLife3 = new PictureBox();
            picLife3.Location = new Point(this.Width - 45, 45);
            picLife3.Size = new Size(45, 45);
            picLife3.Name = "pictureLife";
            picLife3.Image = imgLife.Images[0];
            Controls.Add(picLife3);
            picLife3.BringToFront();

        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 10th, 2016
        * Description: Makes actions correspond to key presses
        * ********************************************************/
        private void MainGame_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left: if (currentDir == Direction.Left) currentDir = Direction.None; break;
                case Keys.Right: if (currentDir == Direction.Right) currentDir = Direction.None; break;
            }
        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 16th, 2016
        * Description: boost1Touch and boostextension create the 
                       movement of the boost coins in the game
        * ********************************************************/
        public void boost1Touch()
        {
            //Checks if the boost coin touches mat and increases the speed of the mat
            if ((picBoostGoldCoin.Bounds).IntersectsWith(picMat.Bounds))
            {
                boolFast = true;
                boostExtenstion();
            }
            else if ((picBoostGoldCoin.Bounds).IntersectsWith(picMat.Bounds))
            {
                boostExtenstion();
            }
        }
        public void boostExtenstion()
        {
            //Sets the location of the boost coin
            intCoinxValue = rdCoinxValue.Next(0, (this.Width - 44));
            picBoostGoldCoin.Location = new Point(intCoinxValue, intCoinVisibility - 50);
            boolBoostFall = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            

        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 15th, 2016
        * Description: Method for hard mode, to get make coins fall in sin waves 
        * ********************************************************/
        static double doSinCalc(int yval)
        {
            //Calcualtes the x value for the sin wave
            double dblx;

            double y = (double)yval / 30;

            dblx = 30 * (Math.Sin(y) + 10);

            return dblx;

        }

        /**********************************************************
        * Name: Vashista Gande
        * Date: June 10th, 2016
        * Description: Set all accumulated values to 0 and make all
        *              previously loaded images invisible 
        * ********************************************************/
        public static void resetData()
        {
            // Sets ever data to zero
            intScore =0;
            intLife=0;
            intGameCounter=0;
            intCointCounter=0;
            intBadCoinCounter=0;
            intFast=0;
            boolBoostFall = false;
            blnTimer = false;
            boolFast = false;
            
        }


    }
}
