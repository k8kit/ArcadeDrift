using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeDrift
{
    // ✅ INHERITANCE: Form1 inherits from the built-in Windows Forms 'Form' class.
    // This gives Form1 all the features of a Form like rendering, handling events, etc.
    public partial class Form1 : Form
    {
        // ✅ ENCAPSULATION: These fields are private and only accessible within this class.
        // This hides internal data (like game state) from other parts of the program.
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;
        bool isPaused = false;
        List<int> highScores = new List<int>();

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;
        
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            panel1.BackColor = ColorTranslator.FromHtml("#474c4b");
        }


        // ✅ ABSTRACTION: This event handler hides keypress logic.
        private void keyisdown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            score ++;
            if (goleft == true && player.Left > 118)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 325)
            {
                player.Left += playerSpeed;
            }
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack1.Top >= roadTrack1.Height)
            {
                roadTrack1.Top = roadTrack2.Top - roadTrack1.Height;
            }
            if (roadTrack2.Top >= roadTrack2.Height)
            {
                roadTrack2.Top = roadTrack1.Top - roadTrack2.Height;
            }
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;
            if (AI1.Top > 800)
            {
                changeAIcars(AI1);
            }
            if (AI2.Top > 800)
            {
                changeAIcars(AI2);
            }
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }
            roadSpeed = 12 + (score / 100);         
            trafficSpeed = 15 + (score / 100);      

            
            if (roadSpeed > 25) roadSpeed = 25;
            if (trafficSpeed > 30) trafficSpeed = 30;
        }
        private void changeAIcars(PictureBox tempCar)
        {
            // ✅ POLYMORPHISM: tempCar is a PictureBox, which could be any car type (child class of Control).
            // You can treat it generically here and still apply specific images.
            carImage = rand.Next(1, 9);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;
            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(110, 190);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(260, 340);
            }
        }
        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8,5);
            explosion.BackColor = Color.Transparent;
            lblScore.Visible = false;
            lblYourScore.Text = $"Your Score: {score}";
            highScores.Add(score);
            highScores = highScores.OrderByDescending(s => s).Take(3).ToList();

            
            lblTopScores.Text = "🏆 Top Scores:\n";
            for (int i = 0; i < highScores.Count; i++)
            {
                lblTopScores.Text += $"{i + 1}. {highScores[i]}\n";
            }

            btnPause.Enabled = false;
            panelGameOver.Visible = true;
            panelGameOver.BringToFront();

        }
        private void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            btnPause.Enabled = true;
            goleft = false;
            goright = false;
            score = 0;
            roadSpeed = 12;
            trafficSpeed = 15;
            AI1.Top = carPosition.Next(200, 800) * -1;
            AI1.Left = carPosition.Next(110, 190);
            AI2.Top = carPosition.Next(200, 800) * -1;
            AI2.Left = carPosition.Next(260, 340);
            gameTimer.Start();
            lblScore.Visible = true;
        }
        // ABSTRACTION: UI click handlers hide the complex game logic
        private void btnStart_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;   
            panel1.Visible = true;    
            ResetGame();                 
            this.ActiveControl = null;  
            this.Focus();
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = true;
            btnHelp.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                btnPause.Enabled = false;
                gameTimer.Stop();
                panelPause.Visible = true;
                isPaused = true;
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            panelPause.Visible = false;
            isPaused = false;
            this.ActiveControl = null;
            this.Focus();
            btnPause.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            panelPause.Visible = false;
            btnPause.Enabled = true;
            isPaused = false;
            ResetGame(); 
            this.ActiveControl = null;
            this.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelGameOver.Visible = false;
            panel1.Visible = false;
            panelMenu.Visible = true;
            btnStart.Enabled = true;
        }

        private void btnRestart2_Click(object sender, EventArgs e)
        {
            panelGameOver.Visible = false;
            ResetGame();
            this.ActiveControl = null;
            this.Focus();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = false;
            btnHelp.Enabled = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; 
                return cp;
            }
        }
    }
}
