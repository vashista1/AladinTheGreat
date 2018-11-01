namespace AladinTheGreat
{
    partial class Intro
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
            this.pnlBackImage = new System.Windows.Forms.Panel();
            this.picRestart = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.pnlBackImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackImage
            // 
            this.pnlBackImage.AutoSize = true;
            this.pnlBackImage.BackgroundImage = global::AladinTheGreat.Properties.Resources.wallpaper_for_aladdin_and_jasmine_aladdin_2462317_1024_768;
            this.pnlBackImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackImage.Controls.Add(this.picRestart);
            this.pnlBackImage.Controls.Add(this.picExit);
            this.pnlBackImage.Controls.Add(this.btnInstructions);
            this.pnlBackImage.Controls.Add(this.btnHighScore);
            this.pnlBackImage.Controls.Add(this.btnStart);
            this.pnlBackImage.Location = new System.Drawing.Point(0, 0);
            this.pnlBackImage.Name = "pnlBackImage";
            this.pnlBackImage.Size = new System.Drawing.Size(1714, 1155);
            this.pnlBackImage.TabIndex = 0;
            // 
            // picRestart
            // 
            this.picRestart.BackColor = System.Drawing.Color.Transparent;
            this.picRestart.BackgroundImage = global::AladinTheGreat.Aladdin.restart;
            this.picRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRestart.Location = new System.Drawing.Point(1512, 12);
            this.picRestart.Name = "picRestart";
            this.picRestart.Size = new System.Drawing.Size(90, 90);
            this.picRestart.TabIndex = 8;
            this.picRestart.TabStop = false;
            this.picRestart.Click += new System.EventHandler(this.picRestart_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::AladinTheGreat.Aladdin.exit;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Location = new System.Drawing.Point(1611, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(90, 90);
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Transparent;
            this.btnInstructions.BackgroundImage = global::AladinTheGreat.Properties.Resources.Untitled;
            this.btnInstructions.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(210, 757);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(434, 115);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.Transparent;
            this.btnHighScore.BackgroundImage = global::AladinTheGreat.Properties.Resources.Untitled;
            this.btnHighScore.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.Location = new System.Drawing.Point(230, 623);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(386, 115);
            this.btnHighScore.TabIndex = 1;
            this.btnHighScore.Text = "High Score";
            this.btnHighScore.UseVisualStyleBackColor = false;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::AladinTheGreat.Properties.Resources.Start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(113, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(488, 313);
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 1156);
            this.Controls.Add(this.pnlBackImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.Text = "Form1";
            this.pnlBackImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackImage;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picRestart;
    }
}

