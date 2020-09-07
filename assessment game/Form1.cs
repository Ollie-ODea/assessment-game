using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace assessment_game
{
    public partial class FrmGame : Form
    {
        Graphics g; //declare a graphics object called g
        BluePlane BluePlane = new BluePlane(); //create the object, BluePlane
        List<Enemy1> Enemy1 = new List<Enemy1>(); //create the object, BluePlane
        bool turnLeft, turnRight, up, down, shoot;
        List<Missile> missiles = new List<Missile>();
        int BluePlanePosX, BluePlanePosY, Enemy1PosX, Enemy1PosY;
        int Espeed;
        int numberOFMissiles = 10;
        Random rand = new Random();

        Rectangle AmmoRec = new Rectangle(0, 0, 20, 20);
        Image AmmoImage = Properties.Resources.ammobox;

        Rectangle CoinRec = new Rectangle(0, 0, 15, 25);
        Image CoinImage = Properties.Resources.Coin;

        Rectangle ExploRec = new Rectangle(0, 0, 20, 20);
        Image ExploImage = Properties.Resources.Explosion;

        int Score = 0;
        bool death;
        bool isletter;
        int startx, starty;


        private void Staminatmr_Tick(object sender, EventArgs e)
        {

            //Parameters for the stamina bar (so that the bar does not exceed the max or min values
            if (StaminaBar.Value > StaminaBar.Maximum - 1)
            {
                StaminaBar.Value = StaminaBar.Maximum;
            }

            if (StaminaBar.Value < StaminaBar.Minimum + 1)
            {
                StaminaBar.Value = StaminaBar.Minimum;
            }

            //Lowering stamina bar
            if (up)
            {
                if (StaminaBar.Value != StaminaBar.Minimum + 1 && StaminaBar.Value != StaminaBar.Minimum - 1)
                {
                    StaminaBar.Value -= 2;
                }

            }
            //increasing stamina bar
            if (down)
            {
                if (StaminaBar.Value < StaminaBar.Maximum)
                {
                    StaminaBar.Value += 1;
                }

            }

                if (StaminaBar.Value < StaminaBar.Maximum)
                {
                    StaminaBar.Value += 1;
                }

                //Base stamina regen

            if (StaminaBar.Value < StaminaBar.Minimum + 3)
            {
                up = false;
            }



        }

        private void TmrAmmo_Tick(object sender, EventArgs e)
        {
            //change ammo location to random and stop the timer
            AmmoRec.X = rand.Next(50,850);
            AmmoRec.Y = rand.Next(50,615);

            TmrAmmo.Enabled = false;
        }

        private void DrawEnemy1tmr_Tick(object sender, EventArgs e)
        {
            //draw new enemy with new speed
            Espeed = 4;
            Enemy1.Add(new Enemy1());
        }

        private void PanlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the Form control
            g = e.Graphics;
               
            //draw all the images
            g.DrawImage(AmmoImage, AmmoRec);
            g.DrawImage(CoinImage, CoinRec);
            g.DrawImage(ExploImage, ExploRec);

            BluePlane.DrawBluePlane(g);

            if (death == true)
            {
                BluePlane.DrawBluePlane(g);
            }



            //draw lists

            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile();
            }

            foreach (Enemy1 Enemy in Enemy1)
            {
                Enemy.DrawEnemy1(g);
            }
        }

        private void tmrCoin_Tick(object sender, EventArgs e)
        {
            //change coins location to random and stop timer
            CoinRec.X = rand.Next(50, 850);
            CoinRec.Y = rand.Next(50, 615);

            tmrCoin.Enabled = false;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When the stop is clicked stop all timers and show the pause picture

            tmrBluePlane.Enabled = false;
            tmrCoin.Enabled = false;
            TmrAmmo.Enabled = false;
            tmrEnemyPlane.Enabled = false;
            Staminatmr.Enabled = false;
            DrawEnemy1tmr.Enabled = false;
            death = false;
            deathpic.Visible = false;

            Pauseimg.Visible = true;


            BluePlanePosX = 10;
            BluePlanePosY = 10;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            death = false;
            deathpic.Visible = false;
            if (isletter == false)
            {
                txtName.Focus();
                MessageBox.Show("please enter a name");
            }
            else
            {

                //When the start is clicked start all timers, deselect the text box, and make sure the pause sign is not visible
                tmrBluePlane.Enabled = true;
                tmrCoin.Enabled = true;
                TmrAmmo.Enabled = true;
                tmrEnemyPlane.Enabled = true;
                Staminatmr.Enabled = true;
                DrawEnemy1tmr.Enabled = true;

                txtName.Enabled = false;
                Pauseimg.Visible = false;

                //blueplane start
                startx = 100;
                starty = 100;
                BluePlane.Start(startx, starty);

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            {
                //code to verify the text being inputted

                string context = txtName.Text;
                isletter = true;
                //for loop checks for letters as characters are entered
                for (int i = 0; i < context.Length; i++)
                {
                    if (!char.IsLetter(context[i]))//if current character not a letter
                    {
                        isletter = false;//make isletter false
                        break; // exit the for loop
                    }
                }
                //if not a letter clear the textbox and focus on it
                // to enter name again
                if (isletter == false)
                {
                    txtName.Clear();
                    txtName.Focus();
                    MessageBox.Show("Please enter a valid character");
                }
                else
                {
                    startToolStripMenuItem.Enabled = true;
                }
            }
        }

        public FrmGame()

        {
            InitializeComponent();

            //stops the panel and everything on it from buffering constantly
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PanlGame, new object[] { true });
        }
        //Movement tick
        private void tmrBluePlane_Tick(object sender, EventArgs e)
        {
            //blue plane turning and movement

            if (turnRight)
            {
                BluePlane.rotationAngle += 6;
            }
            if (turnLeft)
            {
                BluePlane.rotationAngle -= 6;
            }
            if (up) // if left arrow key pressed
            {
                if (BluePlane.speed != 10)
                {
                    BluePlane.speed += 1;
                }
            }
            if (down) // if left arrow key pressed
            {
                if (BluePlane.speed != 3)
                {
                    BluePlane.speed -= 1;
                }
            }
            if (up != true) // if left arrow key pressed
            {
                if (BluePlane.speed > 6)
                {
                    BluePlane.speed -= 1;
                }
            }
            if (down != true) // if left arrow key pressed
            {
                if (BluePlane.speed < 6)
                {
                    BluePlane.speed += 1;
                }
            }
            if (shoot && numberOFMissiles > 0)
            {
                //if you have missiles available shoot.
                missiles.Add(new Missile(BluePlane.BluePlaneRec, BluePlane.rotationAngle));
                numberOFMissiles--;
                shoot = false;

            }
            //update the rotation angle and movment of blueplane
            BluePlane.Rotateplane(BluePlane.rotationAngle, BluePlane.speed);
            BluePlane.MoveBluePlane();

            if (BluePlane.BluePlaneRec.IntersectsWith(AmmoRec))
            {
                //give more ammo when touching ammo box
                TmrAmmo.Enabled = true;
                numberOFMissiles = 10;
            }

            if (BluePlane.BluePlaneRec.IntersectsWith(CoinRec))
            {
                //add 1 score when touching a coin
                tmrCoin.Enabled = true;
                Score += 1;

                if (Score == 10)
                {
                    foreach (Enemy1 Enemy1 in Enemy1)
                    {
                        Enemy1.RotateEnemy1(Espeed);
                        DrawEnemy1tmr.Interval -= 10;
                    }

                }
                if (Score == 20)
                {
                    foreach (Enemy1 Enemy1 in Enemy1)
                    {
                        Enemy1.RotateEnemy1(Espeed);
                        DrawEnemy1tmr.Interval -= 10;
                    }
                }
                if (Score == 30)
                {
                    foreach (Enemy1 Enemy1 in Enemy1)
                    {
                        Enemy1.RotateEnemy1(Espeed);
                        DrawEnemy1tmr.Interval -= 10;
                    }
                }
                if (Score == 40)
                {
                    foreach (Enemy1 Enemy1 in Enemy1)
                    {
                        Enemy1.RotateEnemy1(Espeed);
                        DrawEnemy1tmr.Interval -= 10;
                    }
                }
                if (Score == 50)
                {
                    foreach (Enemy1 Enemy1 in Enemy1)
                    {
                        Enemy1.RotateEnemy1(Espeed);
                        DrawEnemy1tmr.Interval -= 10;
                    }
                }


            }
        


                    //updating the text boxes to show score and ammo
                    lblAmmo.Text = numberOFMissiles.ToString();
            lblScore.Text = Score.ToString();


            //Parameters for the sides and top of panel
            if (BluePlane.x < 0)
            {
                BluePlane.x = 0;
            }

            if (BluePlane.x > 862)
            {
                BluePlane.x = 862;
            }
            if (BluePlane.y < 0)
            {
                BluePlane.y = 0;
            }
            if (BluePlane.y > 613)
            {
                BluePlane.y = 613;
            }
            //if the enemy intersecst with the player die.
            foreach (Enemy1 Enemy in Enemy1)
            {
                if (BluePlane.BluePlaneRec.IntersectsWith(Enemy.Enemy1Rec))
                {
                    death = true;
                    Enemy1.Remove(Enemy);
                    break;

                }
            }

            if (death == true)
            {
                //stop all timers and show death
                tmrBluePlane.Enabled = false;
                tmrCoin.Enabled = false;
                TmrAmmo.Enabled = false;
                tmrEnemyPlane.Enabled = false;
                Staminatmr.Enabled = false;
                DrawEnemy1tmr.Enabled = false;

                Pauseimg.Visible = false;
                deathpic.Visible = true;


            }

            //invalidate
            PanlGame.Invalidate(); 
        }

        private void tmrEnemyPlane_Tick(object sender, EventArgs e)
        {
            //update enemy movement
            foreach (Enemy1 Enemy1 in Enemy1)
            {
                Enemy1.MoveEnemy1();
                Enemy1.RotateEnemy1(Espeed);
            }
            BluePlanePosX = BluePlane.BluePlaneRec.Location.X;
            BluePlanePosY = BluePlane.BluePlaneRec.Location.Y;
            foreach (Enemy1 Enemy1 in Enemy1)
            {
                //cacluate the roatation angle
                Enemy1PosX = Enemy1.Enemy1Rec.Location.X;
                Enemy1PosY = Enemy1.Enemy1Rec.Location.Y;
                Enemy1.rotationAngle = (int)Enemy1.CalculateAngle(Enemy1PosX, Enemy1PosY, BluePlanePosX, BluePlanePosY);
            }
            foreach (Enemy1 Enemy in Enemy1)
            {

                foreach (Missile m in missiles)
                {
                    if (Enemy.Enemy1Rec.IntersectsWith(m.missileRec))
                    {
                        //if a missile hits a enemy
                        missiles.Remove(m);// remove missile
                        Enemy1.Remove(Enemy);

                        break;
                    }
                }
                break;

            }

        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            //fill stamina bar on start
            StaminaBar.Value = StaminaBar.Maximum;
            //stop all timers
            tmrBluePlane.Enabled = false;
            tmrCoin.Enabled = false;
            TmrAmmo.Enabled = false;
            tmrEnemyPlane.Enabled = false;
            Staminatmr.Enabled = false;
            DrawEnemy1tmr.Enabled = false;

            Pauseimg.Visible = false;
            deathpic.Visible = false;

            MessageBox.Show("Turn your plane side to side with the arrow keys. \n Press space to shoot at the enemy planes. \n collect coins and ammo to stay alive. \n Type your name in and press the start to begin. \n Warning you will die if a enemy plane touches you. \n \n press 'ok' to begin", "Game Instructions");
            txtName.Focus();
        }


        //Paint events
        private void FrmGame_Paint(object sender, PaintEventArgs e)
        {

        }
        //Key events
        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            //key events
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
            if (e.KeyData == Keys.Space) { shoot = false; }
        }
        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            //key events
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
            if (e.KeyData == Keys.Space)
            {
                shoot = true;
            }
        }

    }
}
