﻿using System;
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
        public const string BACKGROUND_IMAGE_3 = "../../Images/Town and Sky/City3.wmf";

        private string background = BACKGROUND_IMAGE_2;
        private string background1 = BACKGROUND_IMAGE_1;

        private int horizontalSpeed = 10;
        string baseFileName;

        private Animation animation = new Animation(4);

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

        private void updateImage(object sender, EventArgs e) 
        {
            //copterPictureBox.Image = animation.GetNextImage();
            pigPictureBox.Image = animation.GetNextImage();

            //copterPictureBox.Left += horizontalSpeed;
            pigPictureBox.Left += horizontalSpeed;

            // If the copter goes off the right hand side

            if (copterPictureBox.Left > this.Width)
            {
                copterPictureBox.Top += VERTICAL_SPEED;
                copterPictureBox.Left = -copterPictureBox.Width;

                //Image image = Image.FromFile("../../Images/Town and Sky/City2.wmf");

                if (background1 == BACKGROUND_IMAGE_1)
                {
                    background = BACKGROUND_IMAGE_2;
                }
                else
                {
                    background1 = BACKGROUND_IMAGE_1;
                }

                Bitmap bitmap = new Bitmap(background);
                BackgroundImage = bitmap;
            }
            if (pigPictureBox.Left > this.Width)
            {
                pigPictureBox.Top += VERTICAL_SPEED;
                pigPictureBox.Left = -pigPictureBox.Width;

                if (background1 == BACKGROUND_IMAGE_1)
                {
                    background = BACKGROUND_IMAGE_2;
                }
                else
                {
                    background1 = BACKGROUND_IMAGE_1;
                }

                Bitmap bitmap = new Bitmap(background1);
                BackgroundImage = bitmap;
            }

            if (copterPictureBox.Top > this.Height - copterPictureBox.Height)
            {
                copterPictureBox.Top = VERTICAL_SPEED;
            }
            if (pigPictureBox.Top > this.Height - pigPictureBox.Height)
            {
                pigPictureBox.Top = VERTICAL_SPEED;
            }
        }

        private void loadImages(object sender, EventArgs e)
        {
            //baseFileName = "../../Images/Copter/copter";
            //animation.LoadImages(baseFileName);

             baseFileName = "../../Images/Pigs/pig";
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
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Close();
        }  
    }
}
