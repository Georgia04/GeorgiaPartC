﻿namespace WindowsFormsPartC.Unit5
{
    partial class AnimationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animationPictureBox = new System.Windows.Forms.PictureBox();
            this.startAnimation = new System.Windows.Forms.Button();
            this.stopAnimation = new System.Windows.Forms.Button();
            this.quitAnimation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butterflyRadio = new System.Windows.Forms.RadioButton();
            this.horseRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animationPictureBox
            // 
            this.animationPictureBox.Location = new System.Drawing.Point(141, 96);
            this.animationPictureBox.Name = "animationPictureBox";
            this.animationPictureBox.Size = new System.Drawing.Size(147, 137);
            this.animationPictureBox.TabIndex = 0;
            this.animationPictureBox.TabStop = false;
            // 
            // startAnimation
            // 
            this.startAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startAnimation.Location = new System.Drawing.Point(69, 473);
            this.startAnimation.Name = "startAnimation";
            this.startAnimation.Size = new System.Drawing.Size(119, 47);
            this.startAnimation.TabIndex = 1;
            this.startAnimation.Text = "Start";
            this.startAnimation.UseVisualStyleBackColor = true;
            // 
            // stopAnimation
            // 
            this.stopAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stopAnimation.Location = new System.Drawing.Point(267, 473);
            this.stopAnimation.Name = "stopAnimation";
            this.stopAnimation.Size = new System.Drawing.Size(113, 47);
            this.stopAnimation.TabIndex = 2;
            this.stopAnimation.Text = "Stop";
            this.stopAnimation.UseVisualStyleBackColor = true;
            // 
            // quitAnimation
            // 
            this.quitAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitAnimation.Location = new System.Drawing.Point(481, 473);
            this.quitAnimation.Name = "quitAnimation";
            this.quitAnimation.Size = new System.Drawing.Size(106, 47);
            this.quitAnimation.TabIndex = 3;
            this.quitAnimation.Text = "Quit";
            this.quitAnimation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.horseRadio);
            this.panel1.Controls.Add(this.butterflyRadio);
            this.panel1.Location = new System.Drawing.Point(677, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 86);
            this.panel1.TabIndex = 4;
            // 
            // butterflyRadio
            // 
            this.butterflyRadio.AutoSize = true;
            this.butterflyRadio.Location = new System.Drawing.Point(15, 12);
            this.butterflyRadio.Name = "butterflyRadio";
            this.butterflyRadio.Size = new System.Drawing.Size(81, 21);
            this.butterflyRadio.TabIndex = 0;
            this.butterflyRadio.TabStop = true;
            this.butterflyRadio.Text = "Butterfly";
            this.butterflyRadio.UseVisualStyleBackColor = true;
            // 
            // horseRadio
            // 
            this.horseRadio.AutoSize = true;
            this.horseRadio.Location = new System.Drawing.Point(15, 53);
            this.horseRadio.Name = "horseRadio";
            this.horseRadio.Size = new System.Drawing.Size(67, 21);
            this.horseRadio.TabIndex = 1;
            this.horseRadio.TabStop = true;
            this.horseRadio.Text = "Horse";
            this.horseRadio.UseVisualStyleBackColor = true;
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quitAnimation);
            this.Controls.Add(this.stopAnimation);
            this.Controls.Add(this.startAnimation);
            this.Controls.Add(this.animationPictureBox);
            this.Name = "AnimationForm";
            this.Text = "Georgia\'s Animation";
            this.Load += new System.EventHandler(this.AnimationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox animationPictureBox;
        private System.Windows.Forms.Button startAnimation;
        private System.Windows.Forms.Button stopAnimation;
        private System.Windows.Forms.Button quitAnimation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton horseRadio;
        private System.Windows.Forms.RadioButton butterflyRadio;
    }
}

