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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserLandingPage UserLandingPages = new UserLandingPage();
            UserLandingPages.Show();
            this.Hide();
        }

        private void Votersbtn_Click(object sender, EventArgs e)
        {
            UserCandidates UserCandidates = new UserCandidates();
            UserCandidates.Show();
            this.Hide();
        }
    }
}
