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
        // start position of ball
        int x = 200, y = 50;
        // amount of movement for each tick
        int xmove = 10, ymove = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // add 10 to x and y positions
            x += xmove;
            if (x < 0)
            {
                xmove = -xmove;
            }
            else if (x + 5 > pictureBox1.Width)
            {
                xmove = -xmove;
            }
            y += ymove;
            if (y < 0)
            {
                ymove = -ymove;
            }
            else if (y + 5 > pictureBox1.Height)
            {
                ymove = -ymove;
            }
            Refresh();
        }

        private void startForm_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopForm_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            // get a graphics object
            Graphics g = e.Graphics;

            // draw a red ball, size 30, at x, y position
            g.FillEllipse(Brushes.Red, x, y, size,size);

        }

        int size = 30;
        
        public BouncingBallForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Depending on the button pressed the ball can change size.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string input;

            input = keyData.ToString();

            if (input == "Up")
            {
                MessageBox.Show("You pressed Up");
                size = size + 10;
                return true;
            }
            if (input == "Down")
            {
                MessageBox.Show("You pressed Down");
                size = size - 10;
                return true;
            }
            // return true if key processed, otherwise false
            return false;
        }
    }
}
