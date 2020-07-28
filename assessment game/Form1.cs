using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment_game
{
    public partial class FrmGame : Form
    {
        Graphics g; //declare a graphics object called g
        BluePlane BluePlane = new BluePlane(); //create the object, BluePlane

        public FrmGame()
        {
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the BluePlane class's DrawPlanet method to draw the image BluePlane 
            BluePlane.DrawBluePlane(g);

        } 
    }

}
