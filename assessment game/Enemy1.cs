using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

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

        public Rectangle Enemy1Rec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)

        public Enemy1()
        {
            x = 100;
            y = 100;
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
    }
}
