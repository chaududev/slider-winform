using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
namespace SliderProject
{
    public partial class ShowSlider : Form
    {
        List<string> _paths = new List<string>();
        int selectedIndex = 0;
        public ShowSlider(List<string>paths)
        {
            InitializeComponent();
            Random rnd = new Random();
            if (AppConfig.ngaunhien) {
                pictureBox1.ImageLocation = paths[rnd.Next(0, paths.Count )];
            }
            else {
                pictureBox1.ImageLocation = paths[selectedIndex];
            }
            _paths = paths;
            initForm();
        }

        public void initForm()
        {
            SetInterval(() => {
                if (AppConfig.lap)
                {
                    if (selectedIndex >= _paths.Count-1)
                    {
                        selectedIndex = 0;
                    }
                    else
                    {
                        selectedIndex++;
                    }

                }
                else
                {
                    if (selectedIndex >= _paths.Count-1)
                    {
                        selectedIndex = _paths.Count;
                    }
                    else
                    {
                        selectedIndex++;
                    }

                }
                Random rnd = new Random();
                if (AppConfig.ngaunhien) pictureBox1.ImageLocation = _paths[rnd.Next(0, _paths.Count )];
                else pictureBox1.ImageLocation = _paths[selectedIndex];


            }, TimeSpan.FromSeconds(AppConfig.time));

        }

        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);

            action();

            SetInterval(action, timeout);
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            //next
           
            if (selectedIndex >= _paths.Count-1)
            {
                selectedIndex = 0;
            }
            else
            {
                selectedIndex++;
            }
            pictureBox1.ImageLocation = _paths[selectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedIndex <= 1)
            {
                selectedIndex = 0;
            }
            else
            {
                selectedIndex--;
            }
            pictureBox1.ImageLocation = _paths[selectedIndex];
        }
    }
}
