using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text2Image
{
    public partial class Form2 : Form1
    {
        Form1 originalForm;
        public Form2(Form1 incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            originalForm.Text = EnImage_tbx.Text;
            originalForm.populate();
            this.Close();
                                
            pictureBox1.Load(openFileDialog1.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
