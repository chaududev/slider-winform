using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SliderProject
{
    public partial class ShowImage : Form
    {
        public ShowImage(String imagePath)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = imagePath;
        }
    }
}
