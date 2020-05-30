namespace WindowsFormsPartC.Unit5
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
            this.components = new System.ComponentModel.Container();
            this.animationPictureBox = new System.Windows.Forms.PictureBox();
            this.startAnimation = new System.Windows.Forms.Button();
            this.stopAnimation = new System.Windows.Forms.Button();
            this.quitForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.horseRadio = new System.Windows.Forms.RadioButton();
            this.butterflyRadio = new System.Windows.Forms.RadioButton();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.updateDateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // animationPictureBox
            // 
            this.animationPictureBox.Location = new System.Drawing.Point(454, 272);
            this.animationPictureBox.Name = "animationPictureBox";
            this.animationPictureBox.Size = new System.Drawing.Size(126, 116);
            this.animationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.animationPictureBox.TabIndex = 0;
            this.animationPictureBox.TabStop = false;
            // 
            // startAnimation
            // 
            this.startAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startAnimation.Location = new System.Drawing.Point(39, 589);
            this.startAnimation.Name = "startAnimation";
            this.startAnimation.Size = new System.Drawing.Size(119, 47);
            this.startAnimation.TabIndex = 1;
            this.startAnimation.Text = "Start";
            this.startAnimation.UseVisualStyleBackColor = true;
            this.startAnimation.Click += new System.EventHandler(this.startAnimation_Click);
            // 
            // stopAnimation
            // 
            this.stopAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stopAnimation.Location = new System.Drawing.Point(260, 589);
            this.stopAnimation.Name = "stopAnimation";
            this.stopAnimation.Size = new System.Drawing.Size(113, 47);
            this.stopAnimation.TabIndex = 2;
            this.stopAnimation.Text = "Stop";
            this.stopAnimation.UseVisualStyleBackColor = true;
            this.stopAnimation.Click += new System.EventHandler(this.stopAnimation_Click);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(474, 589);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(106, 47);
            this.quitForm.TabIndex = 3;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.horseRadio);
            this.panel1.Controls.Add(this.butterflyRadio);
            this.panel1.Location = new System.Drawing.Point(801, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 104);
            this.panel1.TabIndex = 1;
            // 
            // horseRadio
            // 
            this.horseRadio.AutoSize = true;
            this.horseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.horseRadio.Location = new System.Drawing.Point(15, 53);
            this.horseRadio.Name = "horseRadio";
            this.horseRadio.Size = new System.Drawing.Size(99, 33);
            this.horseRadio.TabIndex = 1;
            this.horseRadio.TabStop = true;
            this.horseRadio.Text = "Horse";
            this.horseRadio.UseVisualStyleBackColor = true;
            this.horseRadio.CheckedChanged += new System.EventHandler(this.loadImages);
            // 
            // butterflyRadio
            // 
            this.butterflyRadio.AutoSize = true;
            this.butterflyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.butterflyRadio.Location = new System.Drawing.Point(15, 12);
            this.butterflyRadio.Name = "butterflyRadio";
            this.butterflyRadio.Size = new System.Drawing.Size(120, 33);
            this.butterflyRadio.TabIndex = 0;
            this.butterflyRadio.TabStop = true;
            this.butterflyRadio.Text = "Butterfly";
            this.butterflyRadio.UseVisualStyleBackColor = true;
            this.butterflyRadio.CheckedChanged += new System.EventHandler(this.loadImages);
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.updateImage);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Location = new System.Drawing.Point(657, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 116);
            this.panel2.TabIndex = 4;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timeLabel.Location = new System.Drawing.Point(15, 64);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(287, 33);
            this.timeLabel.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateLabel.Location = new System.Drawing.Point(15, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(287, 32);
            this.dateLabel.TabIndex = 0;
            // 
            // updateDateTimer
            // 
            this.updateDateTimer.Enabled = true;
            this.updateDateTimer.Tick += new System.EventHandler(this.updateDateTimer_Tick);
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1142, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.stopAnimation);
            this.Controls.Add(this.startAnimation);
            this.Controls.Add(this.animationPictureBox);
            this.Name = "AnimationForm";
            this.Text = "Georgia\'s Animation";
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox animationPictureBox;
        private System.Windows.Forms.Button startAnimation;
        private System.Windows.Forms.Button stopAnimation;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton horseRadio;
        private System.Windows.Forms.RadioButton butterflyRadio;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer updateDateTimer;
    }
}

