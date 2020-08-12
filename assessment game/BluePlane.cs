using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace assessment_game
{
    class BluePlane
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image BluePlaneImage;//variable for the planet's image
        public double xSpeed, ySpeed;
        public int rotationAngle;
        public int speed;
        public Matrix matrix;
        Point centre;

        public Rectangle BluePlaneRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public BluePlane()
        {
            x = 10;
            y = 10;
            width = 30;
            height = 30;
            rotationAngle = 0;
            speed = 4;
            //planetImage contains the BluePlane.png image
            BluePlaneImage = Properties.Resources.BluePlane;
            BluePlaneRec = new Rectangle(x, y, width, height);

        }

        // Methods for the Planet class
        public void DrawBluePlane(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(BluePlaneRec.X + width / 2, BluePlaneRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(BluePlaneImage, BluePlaneRec);
        }

        public void MoveBluePlane()
        {
            x += (int)xSpeed;
            y -= (int)ySpeed;
            BluePlaneRec.Location = new Point(x, y);//missiles new location
        }
        public void Rotateplane(int BluePlaneRotate, int speed)
        {
            xSpeed = speed * (Math.Cos((BluePlaneRotate - 90) * Math.PI / 180));
            ySpeed = speed * (Math.Sin((BluePlaneRotate + 90) * Math.PI / 180));
        }
    }
}