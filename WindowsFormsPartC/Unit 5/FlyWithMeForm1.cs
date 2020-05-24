using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsPartC.Unit5
{
   /// This form shows an animation of a helicopter and a pig which will fly across
    /// and down the screen.
    /// </summary>
    /// Author:Geogia Gkegka
    public partial class FlyWithMeForm : Form
    {
        public const int VERTICAL_SPEED = 100;

        public const string BACKGROUND_IMAGE_1 = "../../Images/Town and Sky/City1.wmf";
        public const string BACKGROUND_IMAGE_2 = "../../Images/Town and Sky/City2.wmf";

        private string background = BACKGROUND_IMAGE_2;

        private int horizontalSpeed = 10;

        private Animation animation = new Animation(4);
        private Animation animation2 = new Animation(4);

        public FlyWithMeForm()
        {
            InitializeComponent();
        }

        private void startStopAnimation(object sender, EventArgs e)
        {
            if (stopRadio.Checked)
            {
                animationTimer.Enabled = false;
            }
            else
            {
                animationTimer.Enabled = true;
            }

        }

        private void updateCopter(object sender, EventArgs e) 
        {
            copterPictureBox.Image = animation.GetNextImage();

            copterPictureBox.Left += horizontalSpeed;

            // If the copter goes off the right hand side

            if (copterPictureBox.Left > this.Width)
            {
                copterPictureBox.Top += VERTICAL_SPEED;
                copterPictureBox.Left = -copterPictureBox.Width;

                //Image image = Image.FromFile("../../Images/Town and Sky/City2.wmf");

                if (background == BACKGROUND_IMAGE_1)
                {
                    background = BACKGROUND_IMAGE_2;
                }
                else
                {
                    background = BACKGROUND_IMAGE_1;
                }

                Bitmap bitmap = new Bitmap(background);
                BackgroundImage = bitmap;
            }


            if (copterPictureBox.Top > this.Height - copterPictureBox.Height)
            {
                copterPictureBox.Top = VERTICAL_SPEED;
            }
        }

        private void loadImages(object sender, EventArgs e)
        {
            string baseFileName = "../../Images/Copter/copter";
            animation.LoadImages(baseFileName);
        }

        private void changeSpeed(object sender, EventArgs e)
        {
            int speed = (int)speedNumericUpDown.Value;

            switch (speed)
            {
                case 1: animationTimer.Interval = 80; break;
                case 2: animationTimer.Interval = 60; break;
                case 3: animationTimer.Interval = 40; break;
                case 4: animationTimer.Interval = 20; break;
                case 5: animationTimer.Interval = 10; break;

                default: animationTimer.Interval = 80; break;
            }

            switch(speed)
            {
                case 1: animationTimer2.Interval = 80; break;
                case 2: animationTimer2.Interval = 60; break;
                case 3: animationTimer2.Interval = 40; break;
                case 4: animationTimer2.Interval = 20; break;
                case 5: animationTimer2.Interval = 10; break;

                default: animationTimer2.Interval = 80; break;
            }
        }

        private void loadImages2(object sender, EventArgs e)
        {
            string baseFileName = "../../Images/Pigs/Pig";
            animation.LoadImages(baseFileName);
        }

        private void updatePig(object sender, EventArgs e)
        {
            pigPictureBox.Image = animation2.GetNextImage();

            pigPictureBox.Left += horizontalSpeed;

            // If the pig goes off the right hand side

            if (pigPictureBox.Left > this.Width)
            {
                pigPictureBox.Top += VERTICAL_SPEED;
                pigPictureBox.Left = -pigPictureBox.Width;

                //Image image = Image.FromFile("../../Images/Town and Sky/City2.wmf");

                if (background == BACKGROUND_IMAGE_1)
                {
                    background = BACKGROUND_IMAGE_2;
                }
                else
                {
                    background = BACKGROUND_IMAGE_1;
                }

                Bitmap bitmap = new Bitmap(background);
                BackgroundImage = bitmap;
            }


            if (pigPictureBox.Top > this.Height - pigPictureBox.Height)
            {
                pigPictureBox.Top = VERTICAL_SPEED;
            }
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
