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
    public partial class LevelSelect : Form
    {
        PictureBox picLevelScreenBack;
        public static bool variables = false;
        public static string strName;
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void LevelSelect_Load(object sender, EventArgs e)
        {

        }

        public void pictures()
        {
            picLevelScreenBack = new PictureBox();
            picLevelScreenBack.Location = new Point((this.Width / 2) - 120, this.Bottom - 150);
            picLevelScreenBack.Size = new Size(1600, 1100);
            picLevelScreenBack.Name = "pictureMat";
            picLevelScreenBack.Image = Aladdin.LevelScreen;
            Controls.Add(picLevelScreenBack);
            picLevelScreenBack.BringToFront();


        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            variables = true;
            btnHard.Enabled = false;
            picLevel.Image = Aladdin.Simple_Form;
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            txtName.Text = strName;
            this.Hide();
            (new MainGame()).Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strName = txtName.Text;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            variables = false;
            btnEasy.Enabled = false;
            picLevel.Image = Aladdin.Screen_Shot_2016_06_14_at_2_47_30_PM;
        }
    }
}
