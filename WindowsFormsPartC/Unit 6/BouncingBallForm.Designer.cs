namespace WindowsFormsPartC
{
    partial class BouncingBallForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startForm = new System.Windows.Forms.Button();
            this.stopForm = new System.Windows.Forms.Button();
            this.quitForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startForm
            // 
            this.startForm.AutoSize = true;
            this.startForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startForm.Location = new System.Drawing.Point(188, 661);
            this.startForm.Name = "startForm";
            this.startForm.Size = new System.Drawing.Size(126, 49);
            this.startForm.TabIndex = 1;
            this.startForm.Text = "Start";
            this.startForm.UseVisualStyleBackColor = true;
            this.startForm.Click += new System.EventHandler(this.startForm_Click);
            // 
            // stopForm
            // 
            this.stopForm.AutoSize = true;
            this.stopForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stopForm.Location = new System.Drawing.Point(413, 663);
            this.stopForm.Name = "stopForm";
            this.stopForm.Size = new System.Drawing.Size(126, 47);
            this.stopForm.TabIndex = 2;
            this.stopForm.Text = "Stop";
            this.stopForm.UseVisualStyleBackColor = true;
            this.stopForm.Click += new System.EventHandler(this.stopForm_Click);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(651, 661);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(126, 47);
            this.quitForm.TabIndex = 3;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 609);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // BouncingBallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 767);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.stopForm);
            this.Controls.Add(this.startForm);
            this.Name = "BouncingBallForm";
            this.Text = "BouncingBallForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startForm;
        private System.Windows.Forms.Button stopForm;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}