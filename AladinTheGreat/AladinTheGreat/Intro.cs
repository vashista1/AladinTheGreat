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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();//Hides the current form
            (new LevelSelect()).Show();//Opens new form 
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//Exits the application
        }

        private void picRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();//Restarts the application
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            
            (new HighScore()).Show();//Shows the high score window
        }
    }
}
