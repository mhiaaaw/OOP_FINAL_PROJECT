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
    public partial class AdminVotes : Form
    {
        public AdminVotes()
        {
            InitializeComponent();
        }

        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
        }

        private void Votersbtn_Click(object sender, EventArgs e)
        {
            VotersCRUD VotersCRUDs = new VotersCRUD();
            VotersCRUDs.Show();
            this.Hide();
        }

        private void Positionsbtn_Click(object sender, EventArgs e)
        {

        }

        private void Candidatesbtn_Click(object sender, EventArgs e)
        {
            Candicacy c = new Candicacy();
            c.Show();
            this.Hide();
        }
    }
}
