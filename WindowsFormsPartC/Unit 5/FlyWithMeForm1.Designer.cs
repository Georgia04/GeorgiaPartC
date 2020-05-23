namespace WindowsFormsPartC.Unit5
{
    partial class FlyWithMeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlyWithMeForm));
            this.copterPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopRadio = new System.Windows.Forms.RadioButton();
            this.startRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quitForm = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // copterPictureBox
            // 
            this.copterPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copterPictureBox.BackgroundImage")));
            this.copterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copterPictureBox.InitialImage = null;
            this.copterPictureBox.Location = new System.Drawing.Point(254, 72);
            this.copterPictureBox.Name = "copterPictureBox";
            this.copterPictureBox.Size = new System.Drawing.Size(112, 104);
            this.copterPictureBox.TabIndex = 0;
            this.copterPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stopRadio);
            this.panel1.Controls.Add(this.startRadio);
            this.panel1.Location = new System.Drawing.Point(31, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 51);
            this.panel1.TabIndex = 1;
            // 
            // stopRadio
            // 
            this.stopRadio.AutoSize = true;
            this.stopRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stopRadio.Location = new System.Drawing.Point(117, 5);
            this.stopRadio.Name = "stopRadio";
            this.stopRadio.Size = new System.Drawing.Size(84, 33);
            this.stopRadio.TabIndex = 1;
            this.stopRadio.TabStop = true;
            this.stopRadio.Text = "Stop";
            this.stopRadio.UseVisualStyleBackColor = true;
            // 
            // startRadio
            // 
            this.startRadio.AutoSize = true;
            this.startRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startRadio.Location = new System.Drawing.Point(15, 4);
            this.startRadio.Name = "startRadio";
            this.startRadio.Size = new System.Drawing.Size(83, 33);
            this.startRadio.TabIndex = 0;
            this.startRadio.TabStop = true;
            this.startRadio.Text = "Start";
            this.startRadio.UseVisualStyleBackColor = true;
            this.startRadio.CheckedChanged += new System.EventHandler(this.startStopAnimation);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(321, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed";
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.speedNumericUpDown.Location = new System.Drawing.Point(433, 542);
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(69, 38);
            this.speedNumericUpDown.TabIndex = 3;
            this.speedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(684, 542);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(146, 51);
            this.quitForm.TabIndex = 4;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.updateCopter);
            // 
            // FlyWithMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 646);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.speedNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.copterPictureBox);
            this.DoubleBuffered = true;
            this.Name = "FlyWithMeForm";
            this.Text = "FlyWithMeForm";
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox copterPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton stopRadio;
        private System.Windows.Forms.RadioButton startRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Timer animationTimer;
    }
}