using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject_Aleksic
{
    public partial class FormMain : Form
    {
        bool left, right;
        int speed = 10;
        int score = 1;
        int health = 3;

        Random rndX = new Random();
        Random rndY = new Random();

        PictureBox dead = new PictureBox();

        public FormMain()
        {

            InitializeComponent();
            Restart();

            //window icon
            this.Icon = Properties.Resources.pphop_MB5_icon;

        }

        //player movement
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }

        }

        private void MainGameTimer_Tick(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "Score: " + score;

            //moves image and player on timer tick
            if (left == true && player.Left > 0)
            {
                player.Left -= 12;
                player.Image = Properties.Resources.pphopLeft;
            }
            if (right == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.pphop;
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "weapon")
                {

                    x.Top += speed;

                    //if player and weapon intersect with eachother 
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        //spawns red X when player is hit
                        dead.Image = Properties.Resources.redX;
                        dead.Location = x.Location;
                        dead.Height = 30;
                        dead.Width = 30;
                        dead.BackColor = Color.Transparent;

                        this.Controls.Add(dead);

                        health--;
                        x.Top = rndY.Next(80, 300) * -1;
                        x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                        
                    }

                    // if weapon doesnt hit player
                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        x.Top = rndY.Next(80, 700) * -1;
                        x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                        
                    }

                    //speeds up the game 
                    if (score > 300)
                    {
                        speed = 15;
                    }
                    if (score > 500)
                    {
                        speed = 17;
                    }
                    if (score > 700)
                    {
                        speed = 22;
                    }
                    if (score > 1000)
                    {
                        speed = 25;
                    }
                    if (score > 2000)
                    {
                        speed = 27;
                    }
                    if (score > 3000)
                    {
                        speed = 28;
                    }

                    //removes hearts after losing health
                    if (health == 2)
                    {
                        this.Controls.Remove(pictureBoxHealth1);
                    }
                    if (health == 1)
                    {
                        this.Controls.Remove(pictureBoxHealth1);
                        this.Controls.Remove(pictureBoxHealth2);
                    }
                    if (health == 0)
                    {
                        this.Controls.Remove(pictureBoxHealth1);
                        this.Controls.Remove(pictureBoxHealth2);
                        this.Controls.Remove(pictureBoxHealth3);

                        MainGameTimer.Stop();
                        MessageBox.Show("Click Ok to retry", "Game Over!");
                        Restart();
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        //restarts
        private void Restart()
        {
            health = 3;
            this.Controls.Add(pictureBoxHealth1);
            this.Controls.Add(pictureBoxHealth2);
            this.Controls.Add(pictureBoxHealth3);

            this.Controls.Remove(dead);
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "weapon")
                {
                    x.Top = rndY.Next(80, 300) * -1;
                    x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                }
            }
            player.Left = this.ClientSize.Width / 2;

            score = 0;
            speed = 10;

            left = false;
            right = false;

            MainGameTimer.Start();

        }
    }
}
