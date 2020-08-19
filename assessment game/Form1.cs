using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        bool spawn;


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


            if (up)
            {
                if (StaminaBar.Value != StaminaBar.Minimum + 1 && StaminaBar.Value != StaminaBar.Minimum - 1)
                {
                    StaminaBar.Value -= 2;
                }

            }

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



            if (StaminaBar.Value < StaminaBar.Minimum + 3)
            {
                up = false;
            }



        }

        private void DrawEnemy1tmr_Tick(object sender, EventArgs e)
        {
                Enemy1.Add(new Enemy1());
        }

        public FrmGame()

        {
            InitializeComponent();
        }
        //Movement tick
        private void tmrBluePlane_Tick(object sender, EventArgs e)
        {
            
            if (turnRight)
            {
                BluePlane.rotationAngle += 4;
            }
            if (turnLeft)
            {
                BluePlane.rotationAngle -= 4;
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
            if (shoot)
            {
                missiles.Add(new Missile(BluePlane.BluePlaneRec, BluePlane.rotationAngle));
            }
            BluePlane.Rotateplane(BluePlane.rotationAngle, BluePlane.speed);
            BluePlane.MoveBluePlane();
            foreach (Enemy1 Enemy1 in Enemy1)
            {
                Enemy1.MoveEnemy1();
                Enemy1.RotateEnemy1();
            }



            BluePlanePosX = BluePlane.BluePlaneRec.Location.X;
            BluePlanePosY = BluePlane.BluePlaneRec.Location.Y;

            foreach (Enemy1 Enemy1 in Enemy1)
            {


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
                        missiles.Remove(m);// remove missile
                        Enemy1.Remove(Enemy);

                        break;
                    }
                }
                break;

            }

            Invalidate();

            
        }

        private void tmrEnemyPlane_Tick(object sender, EventArgs e)
        {


        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            StaminaBar.Value = StaminaBar.Maximum;
        }


        //Paint events
        private void FrmGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the Form control
            g = e.Graphics;
            //Draw enemy plane
            //Draw the BluePlane
            BluePlane.DrawBluePlane(g);


            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }

            foreach (Enemy1 Enemy in Enemy1)
            {
                Enemy.DrawEnemy1(g);
            }
        }
        //Key events
        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
            if (e.KeyData == Keys.Space) { shoot = false; }
        }
        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
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
