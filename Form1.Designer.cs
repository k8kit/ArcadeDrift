namespace ArcadeDrift
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPause = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.lblTopScores = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRestart2 = new System.Windows.Forms.Button();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblGmaeOver = new System.Windows.Forms.Label();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Label();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblArcadeDrift = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHelp2 = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPause.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelPause);
            this.panel1.Controls.Add(this.panelGameOver);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 780);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panelPause
            // 
            this.panelPause.BackColor = System.Drawing.Color.DimGray;
            this.panelPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPause.Controls.Add(this.lblPause);
            this.panelPause.Controls.Add(this.btnResume);
            this.panelPause.Controls.Add(this.btnRestart);
            this.panelPause.Location = new System.Drawing.Point(57, 174);
            this.panelPause.Name = "panelPause";
            this.panelPause.Size = new System.Drawing.Size(386, 343);
            this.panelPause.TabIndex = 3;
            this.panelPause.Visible = false;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Showcard Gothic", 50F);
            this.lblPause.ForeColor = System.Drawing.Color.Black;
            this.lblPause.Location = new System.Drawing.Point(50, 29);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(285, 166);
            this.lblPause.TabIndex = 2;
            this.lblPause.Text = "Game\r\nPaused";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Green;
            this.btnResume.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Location = new System.Drawing.Point(37, 239);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(125, 75);
            this.btnResume.TabIndex = 1;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Red;
            this.btnRestart.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(223, 239);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(125, 75);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.Black;
            this.panelGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGameOver.Controls.Add(this.lblTopScores);
            this.panelGameOver.Controls.Add(this.btnHome);
            this.panelGameOver.Controls.Add(this.btnRestart2);
            this.panelGameOver.Controls.Add(this.lblYourScore);
            this.panelGameOver.Controls.Add(this.lblGmaeOver);
            this.panelGameOver.Location = new System.Drawing.Point(22, 183);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(452, 399);
            this.panelGameOver.TabIndex = 9;
            this.panelGameOver.Visible = false;
            // 
            // lblTopScores
            // 
            this.lblTopScores.AutoSize = true;
            this.lblTopScores.BackColor = System.Drawing.Color.Transparent;
            this.lblTopScores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopScores.ForeColor = System.Drawing.Color.White;
            this.lblTopScores.Location = new System.Drawing.Point(66, 188);
            this.lblTopScores.Name = "lblTopScores";
            this.lblTopScores.Size = new System.Drawing.Size(99, 18);
            this.lblTopScores.TabIndex = 4;
            this.lblTopScores.Text = "top scores";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Yellow;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(268, 296);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(139, 58);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRestart2
            // 
            this.btnRestart2.BackColor = System.Drawing.Color.Red;
            this.btnRestart2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart2.ForeColor = System.Drawing.Color.White;
            this.btnRestart2.Location = new System.Drawing.Point(43, 299);
            this.btnRestart2.Name = "btnRestart2";
            this.btnRestart2.Size = new System.Drawing.Size(139, 58);
            this.btnRestart2.TabIndex = 2;
            this.btnRestart2.Text = "Restart";
            this.btnRestart2.UseVisualStyleBackColor = false;
            this.btnRestart2.Click += new System.EventHandler(this.btnRestart2_Click);
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.BackColor = System.Drawing.Color.Transparent;
            this.lblYourScore.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.ForeColor = System.Drawing.Color.White;
            this.lblYourScore.Location = new System.Drawing.Point(117, 126);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(215, 34);
            this.lblYourScore.TabIndex = 1;
            this.lblYourScore.Text = "Player score";
            this.lblYourScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGmaeOver
            // 
            this.lblGmaeOver.AutoSize = true;
            this.lblGmaeOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGmaeOver.Font = new System.Drawing.Font("Showcard Gothic", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmaeOver.ForeColor = System.Drawing.Color.White;
            this.lblGmaeOver.Location = new System.Drawing.Point(24, 32);
            this.lblGmaeOver.Name = "lblGmaeOver";
            this.lblGmaeOver.Size = new System.Drawing.Size(400, 83);
            this.lblGmaeOver.TabIndex = 0;
            this.lblGmaeOver.Text = "Game Over";
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::ArcadeDrift.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(116, 82);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 4;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::ArcadeDrift.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(333, 76);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 5;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(256, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(128, 47);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Location = new System.Drawing.Point(116, 9);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(49, 55);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "| |";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = ((System.Drawing.Image)(resources.GetObject("explosion.Image")));
            this.explosion.Location = new System.Drawing.Point(96, 523);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 6;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::ArcadeDrift.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(225, 592);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.BackColor = System.Drawing.Color.Transparent;
            this.roadTrack1.Image = global::ArcadeDrift.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -780);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(498, 780);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 1;
            this.roadTrack1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.BackgroundImage = global::ArcadeDrift.Properties.Resources.roadTrack;
            this.roadTrack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roadTrack2.Image = global::ArcadeDrift.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(498, 780);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 2;
            this.roadTrack2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImage = global::ArcadeDrift.Properties.Resources.background;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.lblArcadeDrift);
            this.panelMenu.Controls.Add(this.btnHelp);
            this.panelMenu.Controls.Add(this.btnStart);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(498, 780);
            this.panelMenu.TabIndex = 0;
            // 
            // lblArcadeDrift
            // 
            this.lblArcadeDrift.AutoSize = true;
            this.lblArcadeDrift.BackColor = System.Drawing.Color.Transparent;
            this.lblArcadeDrift.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArcadeDrift.ForeColor = System.Drawing.Color.Yellow;
            this.lblArcadeDrift.Location = new System.Drawing.Point(-4, 186);
            this.lblArcadeDrift.Name = "lblArcadeDrift";
            this.lblArcadeDrift.Size = new System.Drawing.Size(499, 114);
            this.lblArcadeDrift.TabIndex = 2;
            this.lblArcadeDrift.Text = "Arcade Drift";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Red;
            this.btnHelp.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(168, 642);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(167, 57);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(168, 552);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 57);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.Color.DimGray;
            this.panelHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHelp.Controls.Add(this.btnBack);
            this.panelHelp.Controls.Add(this.lblHelp2);
            this.panelHelp.Controls.Add(this.lblHelp);
            this.panelHelp.Location = new System.Drawing.Point(50, 98);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(399, 585);
            this.panelHelp.TabIndex = 3;
            this.panelHelp.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(270, 527);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 42);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHelp2
            // 
            this.lblHelp2.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp2.ForeColor = System.Drawing.Color.Black;
            this.lblHelp2.Location = new System.Drawing.Point(3, 75);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(396, 486);
            this.lblHelp2.TabIndex = 1;
            this.lblHelp2.Text = resources.GetString("lblHelp2.Text");
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.Black;
            this.lblHelp.Location = new System.Drawing.Point(12, 17);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(292, 45);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "How to Play?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Arcade Drift";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPause.ResumeLayout(false);
            this.panelPause.PerformLayout();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblArcadeDrift;
        private System.Windows.Forms.Label btnPause;
        private System.Windows.Forms.Panel panelPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Label lblGmaeOver;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRestart2;
        private System.Windows.Forms.Label lblTopScores;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.Label lblHelp;
    }
}

