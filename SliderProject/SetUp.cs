using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SliderProject
{
    public partial class SetUp : Form
    {
        public SetUp()
        {
            InitializeComponent();
            if (AppConfig.time <= 0) timer.Value = 1;
            else
            timer.Value = AppConfig.time;
            cbLap.Checked = AppConfig.lap;
            cbNgauNhien.Checked = AppConfig.ngaunhien;
        }

        private void SetUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AppConfig constant;

            AppConfig.time = int.Parse(timer.Text.ToString());
            AppConfig.lap = cbLap.Checked;
            AppConfig.ngaunhien = cbNgauNhien.Checked;
            this.Hide();
        }
    }
}
