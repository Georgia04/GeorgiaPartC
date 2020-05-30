﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit6
{
    public partial class GraphicsForm2 : Form
    {
        public const int BYTE = 256;

        private int x;  // 
        private int y;  // 
        private int w; // width
        private int h; // height

        private char key;

        private bool keyPressed = false;

        private Pen myPen = new Pen(Color.Blue, 10);

        private Random generator = new Random();

        public GraphicsForm2()
        {
            InitializeComponent();
        }

        private Point getRandomPoint()
        {
            x = generator.Next(Width);
            y = generator.Next(Height);

            Point p = new Point(x, y);
            return p;
        }

        private Color getRandomColor()
        {
            int r, g, b;

            r = generator.Next(BYTE);
            g = generator.Next(BYTE);
            b = generator.Next(BYTE);

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// This method will draw  all
        /// the graphics on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawScreen(object sender, PaintEventArgs e) 
        {
           drawStrings(e.Graphics);
           drawRectangles(e.Graphics, 600, 50);
           drawHexagon(e.Graphics, 20, 300);

            if (keyPressed) 
            {
                Point p1 = getRandomPoint();
                Point p2 = getRandomPoint();
                myPen = new Pen(Brushes.Black, 10);

                if (key == 'l')
                {
                    e.Graphics.DrawLine(myPen, p1, p2);
                }
                else if (key == 'r')
                {
                    Rectangle rectangle = new Rectangle(p1.X, p1.Y, 200, 100);
                    e.Graphics.DrawRectangle(myPen, rectangle);
                }
                if (key == 'x')
                {
                    drawCircles(e.Graphics);
                }

                keyPressed = false;
            }
        }

        /// <summary>
        /// Task 6.5 uses the assigned position to create a circle
        /// on the screen, the colour can also change.
        /// </summary>
        private void drawCircles(Graphics g)
        {
            x = 400; y = 100;

            int size = 400; int decrease = 15;

            Color color;

            Rectangle rectangle;

            for (int n = 1; n <= 10; n++)
            {
                Brush myBrush = new SolidBrush(getRandomColor());
                rectangle = new Rectangle(x, y, size, size);

                g.FillEllipse(myBrush, rectangle);

                size = size - 2 * decrease;
                x = x + decrease;
                y = y + decrease;
            }
        }

        /// <summary>
        /// Task 6.3 draws a hexagon and it places on the screen
        /// in a green colour with a random outline
        /// </summary>
        private void drawHexagon(Graphics graphics, int x, int y)
        {
            int size = 100;
            Point[] hexagon = new Point[]
            {
                new Point (x, y),  // left most corner
                new Point (x + size, y - size),
                new Point (x + size * 2, y - size),
                new Point (x + size * 3, y),
                new Point (x + size * 2, y + size),
                new Point (x + size, y + size)
            };

            graphics.DrawPolygon(myPen, hexagon);
            graphics.FillPolygon(Brushes.Green, hexagon);

            Font myFont = new Font("Helvetica", 30);
            graphics.DrawString("Georgia's Hexagon", myFont, Brushes.Red, x, y + 2 * size - 50);
        }

        /// <summary>
        /// Task 6.2 creates the rectangle on the side and shows
        /// a hole in the middle for the yellow circle.
        /// </summary>
        private void drawRectangles(Graphics g, int x, int y)
        {
            w = 300; h = 200; int size = 20;

            g.DrawRectangle(myPen, x, y, w, h);
            g.FillRectangle(Brushes.Red, x, y, w, h);
            g.FillEllipse(Brushes.Yellow, x, y, w, h);

            y = 300;

            for (int i = 1; i <= 6; i++)
            {
                g.DrawRectangle(myPen, x, y, w, h);
                System.Threading.Thread.Sleep(100);

                x = x + size;
                y = y + size;
                w = w - 2 * size;
                h = h - 2 * size;
            }

            Font myFont = new Font("Helvetica", 30);
            g.DrawString("Georgia's Rectangles", myFont, Brushes.Red, x, y + 5 * size);
        }

        /// <summary>
        /// Task 6.1 shows text on the screen above the
        /// hexagon.
        /// </summary>
        private void drawStrings(Graphics g)
        {
            int fontSize = 30;
            x = 50; y = 20;

            Font myFont = new Font("Courier", fontSize);
            BackColor = Color.Yellow;

            for (int i = 1; i <= 6; i++)
            {
                g.Clear(BackColor);
                g.DrawString("Georgia's Graphics Drawing", myFont, Brushes.Red, x, y);

                System.Threading.Thread.Sleep(200);
                y = y + fontSize;
            }
        }

        /// <summary>
        /// Called when any is pressed
        /// </summary>
        private void drawShape(object sender, KeyPressEventArgs e)
        {
            keyPressed = true;
            key = e.KeyChar;
            Refresh();
        }
    }
}
