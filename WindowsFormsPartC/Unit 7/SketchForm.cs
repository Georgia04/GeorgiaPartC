using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit7
{
    /// <summary>
    /// This form allows the user to draw
    /// multicolors lines on the screen.
    /// Author: Georgia Gkegka
    /// </summary>
    public partial class SketchForm : Form
    {
        private Bitmap canvas;
        public const int Byte = 190;
        private int x = 300;
        private int y = 200;

        private int penSize = 10;

        private bool keyPressed = false;
        private string keyName;
        DialogResult answer;
        private Random generator = new Random();

        public SketchForm()
        {
            InitializeComponent();
        }

        private void SketchForm_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(sketchPanel.Width, sketchPanel.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.FillEllipse(Brushes.Red, x, y, penSize, penSize);
            sketchPanel.BackgroundImage = canvas;
        }

        /// <summary>
        /// This method allows usert to move 
        /// the line  over the screen by pressing the keys/
        /// When escape is click a box is shown and C resets the form.
        /// Author: Georgia Gkegka
        /// </summary>
        private void drawPoint(Graphics g)
        {
            SolidBrush Brush = new SolidBrush(getRandomColor());
            Rectangle rectangle = new Rectangle(x, y, penSize, penSize);

            if (keyName == "Right")
            {
                x = x + penSize / 2;
            }
            else if (keyName == "Left")
            {
                x = x - penSize / 2;
            }
            else if (keyName == "Up")
            {
                y = y - penSize / 2;
            }
            else if (keyName == "Down")
            {
                y = y + penSize / 2;
            }
            else if (keyName == "B")
            {
                penSize = penSize + 2;
            }
            else if (keyName == "S")
            {
                penSize = penSize - 2;
            }
            else if (keyName == "F1")
            {
                g.FillEllipse(Brush, rectangle);
            }
            else if (keyName == "F2")
            {
                this.BackColor = getRandomColor();
            }
            else if (keyName == "Escape")
            {
                answer = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if (keyName == "C")
            {
                SketchForm sketchForm = new SketchForm();
                sketchForm.Show();
                this.Dispose(false);
            }
            else if (keyName == "Up" && keyName == "Left")
            {
                x = x + penSize / 2;
                y = y + penSize / 2;
            }
            else if (keyName == "Up" && keyName == "Right")
            {
                y = y - penSize / 2;
                x = x + penSize / 2;
            }
            else if (keyName == "Down" && keyName == "Right")
            {
                y = y - penSize / 2;
                x = x - penSize / 2;
            }
            else if (keyName == "Down" && keyName == "Left")
            {
                y = y + penSize / 2;
                x = x - penSize / 2;
            }

            if (keyPressed)
                g.FillEllipse(Brushes.Red, x, y, penSize, penSize);
                g.FillEllipse(Brush, rectangle);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            keyName = keyData.ToString();
            keyPressed = true;

            Refresh();
            return true;
        }

        private void sketchPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(sketchPanel.BackgroundImage);
            drawPoint(g);
        }

        private Color getRandomColor()
        {
            int red, green, blue;

            red = generator.Next(Byte);
            green = generator.Next(Byte);
            blue = generator.Next(Byte);

            return Color.FromArgb(red, green, blue);
        }
    }
}
