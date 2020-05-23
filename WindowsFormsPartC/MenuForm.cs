using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPartC.Unit5;
using WindowsFormsPartC.Unit6;


namespace WindowsFormsPartC
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void runForm_Click(object sender, EventArgs e)
        {
            if (animationRadio.Checked)
            {
                // Tasks 5.1 and 5.2

                AnimationForm form = new AnimationForm();
                form.Show();
            }
            else if (flyWithMeRadio.Checked)
            {
                // Tasks 5.3, 5.4 and 5.5
                FlyWithMeForm form = new FlyWithMeForm();
                form.Show();
            }
            else if (graphicsRadio.Checked)
            {
                // Tasks 6.1 to 6.6
                    GraphicsForm2 form = new GraphicsForm2();
                form.Show();
            }
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
