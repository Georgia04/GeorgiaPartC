using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit5
{
    /// <summary>
    /// Tasks 5.1 and 5.2
    /// This form will display an animated animal moving randomly about on
    /// the form.  The animated character can be selected from a horse and
    /// a butterfly.
    /// Author: Georgia Gkegka
    /// </summary>
    /// </summary>
    public partial class AnimationForm : Form
    {
        private const int MAXN_IMAGES = 8;

        private Image[] images = new Image[MAXN_IMAGES];

        private int imageNo = 0;

        private Random generator = new Random();

        public AnimationForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Load MAXN_IMAGES from gif files and add them to the animation
        /// Picture Box when the form loads or when the animation character
        /// is changed.
        /// </summary>
        

        private void AnimationForm_Load(object sender, EventArgs e)
        {
            string baseFileName;
            if (horseRadio.Checked)
            {
                baseFileName = "../../Images/Horse/horsey";
            }
            else
            {
                baseFileName = "../../Images/Butterflies/bfly";
            }
            for (imageNo = 0; imageNo < MAXN_IMAGES; imageNo++)
            {
                string filename = baseFileName + imageNo + ".gif";
                images[imageNo] = Image.FromFile(filename);
            }
        }
    }
}
