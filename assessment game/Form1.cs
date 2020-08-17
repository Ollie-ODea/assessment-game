using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        Enemy1 Enemy1 = new Enemy1(); //create the object, BluePlane
        bool turnLeft, turnRight, up, down, shoot;
        List<Missile> missiles = new List<Missile>();
        int BluePlanePosX, BluePlanePosY, Enemy1PosX, Enemy1PosY;

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
            Enemy1.MoveEnemy1();
            Enemy1.RotateEnemy1();


            BluePlanePosX = BluePlane.BluePlaneRec.Location.X;
            BluePlanePosY = BluePlane.BluePlaneRec.Location.Y;
            Enemy1PosX = Enemy1.Enemy1Rec.Location.X;
            Enemy1PosY = Enemy1.Enemy1Rec.Location.Y;

            Enemy1.rotationAngle = (int)Enemy1.CalculateAngle(Enemy1PosX, Enemy1PosY, BluePlanePosX, BluePlanePosY);
            Invalidate();

            
        }

        private void tmrEnemyPlane_Tick(object sender, EventArgs e)
        {
           
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
           
        }


        //Paint events
        private void FrmGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the Form control
            g = e.Graphics;
            //Draw enemy plane
            Enemy1.DrawEnemy1(g);
            //Draw the BluePlane
            BluePlane.DrawBluePlane(g);


            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
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
