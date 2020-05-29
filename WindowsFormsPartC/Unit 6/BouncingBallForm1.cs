using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC
{
    public partial class BouncingBallForm : Form
    {
        private int X = 150;

        private int Y = 100;

        public const int Byte = 190;

        private Random generator = new Random();

        private Ball redBall;

        private Ball blueBall;

        private int size = 40;

        private Point getRandomPoint()
        {
            int x = generator.Next(ballPictureBox.Width);
            int y = generator.Next(ballPictureBox.Height);

            Point randomRedPoint = new Point(x, y);
            return randomRedPoint;
        }

        public BouncingBallForm()
        {
            InitializeComponent();
        }

        private void ballPicturePoint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush brush = new SolidBrush(Color.Red);
            redBall.Draw(e.Graphics, brush);

            brush = new SolidBrush(Color.Green);
            blueBall.Draw(e.Graphics, brush);
        }

        private Color getRandomColor()
        {
            int red, green, blue;

            red = generator.Next(Byte);
            green = generator.Next(Byte);
            blue = generator.Next(Byte);

            return Color.FromArgb(red, green, blue);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string input;

            input = keyData.ToString();

            if (input == "Up")
            {
                redBall.Size = size + 20;
                return true;
            }
            if (input == "Down")
            {
                redBall.Size = size - 20;
                return true;
            }

            if (keyData == Keys.C)
            {
                ballPictureBox.BackColor = getRandomColor();
                return true;
            }


            // return true if key processed, otherwise false
            return false;
        }

        private void BouncingBallForm_Load(object sender, EventArgs e)
        {
            Rectangle boundary = new Rectangle(0, 0, ballPictureBox.Width, ballPictureBox.Height);
            redBall = new Ball(boundary);
            blueBall = new Ball(boundary);

            redBall.Position = getRandomPoint();
            blueBall.Position = getRandomPoint();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            redBall.MoveBall();
            blueBall.MoveBall();

            Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Ball 
    {
        public int Size { get; set; }
        public Point Position { get; set; }
        public Point Speed { get; set; }
        public Rectangle Boundary { get; set; }

        public Ball(Rectangle boundary)
        {
            Boundary = boundary;

            Size = 40;
            Position = new Point(150, 50);
            Speed = new Point(15, 15);
        }

        public void MoveBall() 
        {
            Point position = new Point(Position.X + Speed.X, Position.Y + Speed.Y);
            Position = position;

            if (position.X + Size >= Boundary.Width)
            {
                Speed = new Point(-Speed.X, Speed.Y);
            }
            else if (position.Y + Size >= Boundary.Height)
            {
                Speed = new Point(Speed.X, -Speed.Y);
            }
            else if (position.X + Size <= Boundary.X)
            {
                Speed = new Point(-Speed.X, Speed.Y);
            }
            else if (position.Y + Size <= Boundary.Y)
            {
                Speed = new Point(Speed.X, -Speed.Y);
            }
        }

        public void Draw(Graphics g, SolidBrush brush)
        {
            g.FillEllipse(brush, Position.X, Position.Y, Size, Size);
        }
    }
}
