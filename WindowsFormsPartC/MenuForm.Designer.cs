namespace WindowsFormsPartC
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.animationRadio = new System.Windows.Forms.RadioButton();
            this.flyWithMeRadio = new System.Windows.Forms.RadioButton();
            this.graphicsRadio = new System.Windows.Forms.RadioButton();
            this.runForm = new System.Windows.Forms.Button();
            this.quitForm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // animationRadio
            // 
            this.animationRadio.AutoSize = true;
            this.animationRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.animationRadio.Location = new System.Drawing.Point(36, 47);
            this.animationRadio.Name = "animationRadio";
            this.animationRadio.Size = new System.Drawing.Size(518, 33);
            this.animationRadio.TabIndex = 0;
            this.animationRadio.TabStop = true;
            this.animationRadio.Text = "Task 5.1-5.2 Butterfly and Horse Animation";
            this.animationRadio.UseVisualStyleBackColor = true;
            // 
            // flyWithMeRadio
            // 
            this.flyWithMeRadio.AutoSize = true;
            this.flyWithMeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.flyWithMeRadio.Location = new System.Drawing.Point(36, 105);
            this.flyWithMeRadio.Name = "flyWithMeRadio";
            this.flyWithMeRadio.Size = new System.Drawing.Size(393, 33);
            this.flyWithMeRadio.TabIndex = 1;
            this.flyWithMeRadio.TabStop = true;
            this.flyWithMeRadio.Text = "Task 5.3 Fly With Me Animation";
            this.flyWithMeRadio.UseVisualStyleBackColor = true;
            // 
            // graphicsRadio
            // 
            this.graphicsRadio.AutoSize = true;
            this.graphicsRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.graphicsRadio.Location = new System.Drawing.Point(36, 161);
            this.graphicsRadio.Name = "graphicsRadio";
            this.graphicsRadio.Size = new System.Drawing.Size(208, 33);
            this.graphicsRadio.TabIndex = 2;
            this.graphicsRadio.TabStop = true;
            this.graphicsRadio.Text = "Unit 6 Graphics";
            this.graphicsRadio.UseVisualStyleBackColor = true;
            // 
            // runForm
            // 
            this.runForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.runForm.Location = new System.Drawing.Point(48, 565);
            this.runForm.Name = "runForm";
            this.runForm.Size = new System.Drawing.Size(126, 44);
            this.runForm.TabIndex = 3;
            this.runForm.Text = "Run";
            this.runForm.UseVisualStyleBackColor = true;
            this.runForm.Click += new System.EventHandler(this.runForm_Click);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(225, 565);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(123, 44);
            this.quitForm.TabIndex = 4;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(594, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 621);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 645);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.runForm);
            this.Controls.Add(this.graphicsRadio);
            this.Controls.Add(this.flyWithMeRadio);
            this.Controls.Add(this.animationRadio);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton animationRadio;
        private System.Windows.Forms.RadioButton flyWithMeRadio;
        private System.Windows.Forms.RadioButton graphicsRadio;
        private System.Windows.Forms.Button runForm;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}