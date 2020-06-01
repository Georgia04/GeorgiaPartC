namespace WindowsFormsPartC.Unit7
{
    partial class SketchForm
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
            this.sketchPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // sketchPanel
            // 
            this.sketchPanel.BackColor = System.Drawing.SystemColors.Info;
            this.sketchPanel.Location = new System.Drawing.Point(64, 66);
            this.sketchPanel.Name = "sketchPanel";
            this.sketchPanel.Size = new System.Drawing.Size(975, 539);
            this.sketchPanel.TabIndex = 0;
            this.sketchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sketchPanel_Paint);
            // 
            // SketchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1107, 705);
            this.Controls.Add(this.sketchPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SketchForm";
            this.Text = "Georgia\'s Etch a Sketch Form";
            this.Load += new System.EventHandler(this.SketchForm_Load);
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sketchPanel;
    }
}