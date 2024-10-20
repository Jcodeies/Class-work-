

/*
 


 This was created by Juan 14/10/24

The code is used to create a simple house or car using visual studio with the goal of being able to understand and use shapes through code. 
 
 
 
 */






using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ass_1_part_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Draw_House);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Draw_House(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw the body of the house
            g.FillRectangle(Brushes.BurlyWood, 50, 150, 200, 200);

            // Draw the roof
            Point[] roofPoints = { new Point(50, 150), new Point(250, 150), new Point(150, 50) };
            g.FillPolygon(Brushes.SaddleBrown, roofPoints);

            // Draw the door
            g.FillRectangle(Brushes.Sienna, 125, 250, 50, 100);

            // Draw windows
            g.FillRectangle(Brushes.White, 75, 200, 50, 50);
            g.FillRectangle(Brushes.White, 175, 200, 50, 50);
        }
    }
}






