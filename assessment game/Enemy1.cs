using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace assessment_game
{
    class Enemy1
    {

        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image Enemy1Image;//variable for the planet's image
        public double xSpeed, ySpeed;
        public int rotationAngle;
        public Matrix matrix;
        Point centre;
        Random rand = new Random();


        public Rectangle Enemy1Rec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)

        public Enemy1()
        {
            x = 0;
            y = rand.Next(0,665);
            width = 30;
            height = 30;
            rotationAngle = 0;
            //planetImage contains the BluePlane.png image
            Enemy1Image = Properties.Resources.Enemy1;
            Enemy1Rec = new Rectangle(x, y, width, height);


        }

        public void DrawEnemy1(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(Enemy1Rec.X + width / 2, Enemy1Rec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre

            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(Enemy1Image, Enemy1Rec);
        }

        public double CalculateAngle(int startX, int startY, int arrivalX, int arrivalY)
        {
            var radian = Math.Atan2((arrivalY - startY), (arrivalX - startX));
            var angle = (90 + radian * (180 / Math.PI) + 360) % 360;

            return angle;
        }

        public void MoveEnemy1()
        {
            x += (int)xSpeed;
            y -= (int)ySpeed;
            Enemy1Rec.Location = new Point(x, y);//missiles new location
        }
        public void RotateEnemy1(int speed)
        {
            xSpeed = speed * (Math.Cos((rotationAngle - 90) * Math.PI / 180));
            ySpeed = speed * (Math.Sin((rotationAngle + 90) * Math.PI / 180));
        }

    }
}


