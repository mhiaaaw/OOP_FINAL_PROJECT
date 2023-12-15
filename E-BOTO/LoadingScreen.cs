using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_BOTO
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                loading.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
