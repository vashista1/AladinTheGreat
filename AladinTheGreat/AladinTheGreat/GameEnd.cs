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

namespace AladinTheGreat
{
    public partial class GameEnd : Form
    {
        public GameEnd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            //Goes to main menu
            this.Hide();
            MainGame.resetData();
            (new Intro()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Displays highscore
            (new HighScore()).Show();
        }

        private void Pause_Load(object sender, EventArgs e)
        {
            //When the form loads teh score is put on the screen
            MainGame.ActiveForm.Hide();
            lblScore.Text = LevelSelect.strName + "         "+MainGame.intScore+"   "+MainGame.intGameCounter;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //restarts the game
            this.Hide();
            HighScore.scoreWriter();
            MainGame.resetData();
            (new MainGame()).Show();
        }
    }
}
