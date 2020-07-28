using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace assessment_game
{
    class BluePlane
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image BluePlaneImage;//variable for the planet's image

        public Rectangle BluePlaneRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public BluePlane()
        {
            x = 10;
            y = 10;
            width = 200;
            height = 200;
            //planetImage contains the BluePlane.png image
            BluePlaneImage = Properties.Resources.BluePlane;
            BluePlaneRec = new Rectangle(x, y, width, height);

        }

        // Methods for the Planet class
        public void DrawBluePlane(Graphics g)
        {
            g.DrawImage(BluePlaneImage, BluePlaneRec);
        }


    }
}