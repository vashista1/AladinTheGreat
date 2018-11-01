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
    public partial class HighScore : Form
    {
        //Variable Declecration and getting values from other form
        public static int intscore = MainGame.intScore;
        public static int intGame = MainGame.intGameCounter;
        public static FileInfo HighScores = new FileInfo("HighScores.txt");
        public static FileInfo Names = new FileInfo("Names.txt");
        public HighScore()
        {
            //To run method 
            InitializeComponent();
            scoreWriter();
            //To label scores
            label1.Text = "Name                  Score \t Time";
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            //Reads the scores when the form is loaded 
            scoreReader();
        }

        public static void scoreWriter()
        {     
            //Write on the created document    
            StreamWriter T = HighScores.CreateText();
            T.WriteLine(intscore+"  "+intGame);//Add scores and time 
            T.Close();
            StreamWriter X = Names.CreateText();
            X.WriteLine(LevelSelect.strName);//Add Name
            X.Close();
        }
        
        public void scoreReader()
        {
            //variable Decleration
            string Input = null;
            string[] intArray;
            string[] strArray;
            int intCounter = 0;
            string strTempScore;
            string strName;

            //Open the text files
            StreamReader re = File.OpenText("HighScores.txt");
            StreamReader na = File.OpenText("Names.txt");
           
            //Process: While Loop to count the all the numbers in the file
            while ((Input = re.ReadLine()) != null)
            {
                intCounter++;
            }
            re.Close();

            //Assigning the counted values to the length of the array
            intArray = new string[intCounter];
            strArray = new string[intCounter];
            re = File.OpenText("HighScores.txt");
            na = File.OpenText("Names.txt");

            //Assigning the vlaues in the file to the array
            int x = 0;
            while (x != intArray.Length)
            {
                intArray[x] = (re.ReadLine());
                strArray[x] = (na.ReadLine());
                x++;
            }
            
            for (int i = 0; i < intArray.Length; i++)//Loop to go throguh all the data in both forms to sort them 
            {
                for (int n = 0; n < intArray.Length - 1; n++)
                {
                    int arrayn = Int32.Parse(intArray[n].Substring(3));
                    int arrayn1 = Int32.Parse(intArray[n+1].Substring(3));
                    if (arrayn > arrayn1)//Uses operators to sort
                    {
                        strTempScore = intArray[n];
                        intArray[n] = intArray[n + 1];
                        intArray[n + 1] = strTempScore;

                        strName = strArray[n];
                        strArray[n] = strArray[n + 1];
                        strArray[n + 1] = strName;
                    }
                }
            }
            //Display the highscores
            for (int m = 0; m < intArray.Length; m++)
            {
                lblScore.Text=(strArray[m]+"                 "+ intArray[m]);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
