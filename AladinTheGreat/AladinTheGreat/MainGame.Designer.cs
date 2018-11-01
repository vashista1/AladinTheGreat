namespace AladinTheGreat
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.timGame = new System.Windows.Forms.Timer(this.components);
            this.imgGoldCoin = new System.Windows.Forms.ImageList(this.components);
            this.imgMat = new System.Windows.Forms.ImageList(this.components);
            this.imgScore = new System.Windows.Forms.ImageList(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.boostCoin = new System.Windows.Forms.ImageList(this.components);
            this.imgBadCoin = new System.Windows.Forms.ImageList(this.components);
            this.imgLife = new System.Windows.Forms.ImageList(this.components);
            this.picBoxBot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBot)).BeginInit();
            this.SuspendLayout();
            // 
            // timGame
            // 
            this.timGame.Enabled = true;
            this.timGame.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgGoldCoin
            // 
            this.imgGoldCoin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgGoldCoin.ImageStream")));
            this.imgGoldCoin.TransparentColor = System.Drawing.Color.Transparent;
            this.imgGoldCoin.Images.SetKeyName(0, "double-or-nothing-pokerove-turnaje.png");
            // 
            // imgMat
            // 
            this.imgMat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMat.ImageStream")));
            this.imgMat.TransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imgMat.Images.SetKeyName(0, "Mat.png");
            // 
            // imgScore
            // 
            this.imgScore.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgScore.ImageStream")));
            this.imgScore.TransparentColor = System.Drawing.Color.Transparent;
            this.imgScore.Images.SetKeyName(0, "0.png");
            this.imgScore.Images.SetKeyName(1, "1.png");
            this.imgScore.Images.SetKeyName(2, "2.png");
            this.imgScore.Images.SetKeyName(3, "3.png");
            this.imgScore.Images.SetKeyName(4, "4.png");
            this.imgScore.Images.SetKeyName(5, "5.png");
            this.imgScore.Images.SetKeyName(6, "6.png");
            this.imgScore.Images.SetKeyName(7, "7.png");
            this.imgScore.Images.SetKeyName(8, "8.png");
            this.imgScore.Images.SetKeyName(9, "9.png");
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(1439, 177);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "label1";
            // 
            // boostCoin
            // 
            this.boostCoin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("boostCoin.ImageStream")));
            this.boostCoin.TransparentColor = System.Drawing.Color.Transparent;
            this.boostCoin.Images.SetKeyName(0, "boostCoin.png");
            // 
            // imgBadCoin
            // 
            this.imgBadCoin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBadCoin.ImageStream")));
            this.imgBadCoin.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBadCoin.Images.SetKeyName(0, "Baddy.png");
            // 
            // imgLife
            // 
            this.imgLife.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLife.ImageStream")));
            this.imgLife.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLife.Images.SetKeyName(0, "life.png");
            this.imgLife.Images.SetKeyName(1, "bigPause.png");
            // 
            // picBoxBot
            // 
            this.picBoxBot.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBot.Location = new System.Drawing.Point(-2, 1042);
            this.picBoxBot.Name = "picBoxBot";
            this.picBoxBot.Size = new System.Drawing.Size(1585, 5);
            this.picBoxBot.TabIndex = 0;
            this.picBoxBot.TabStop = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1044);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBoxBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgGoldCoin;
        private System.Windows.Forms.ImageList imgMat;
        private System.Windows.Forms.ImageList imgScore;
        private System.Windows.Forms.PictureBox picBoxBot;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ImageList boostCoin;
        private System.Windows.Forms.ImageList imgBadCoin;
        private System.Windows.Forms.ImageList imgLife;
        public System.Windows.Forms.Timer timGame;
    }
}