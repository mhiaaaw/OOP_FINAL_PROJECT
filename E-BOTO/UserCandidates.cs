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
    public partial class UserCandidates : Form
    {
        public UserCandidates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserVote UserVotes = new UserVote();
            UserVotes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserLandingPage UserLandingPages = new UserLandingPage();
            UserLandingPages.Show();
            this.Hide();
        }

        private void UserCandidates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet23.tbl_SKcandidates' table. You can move, or remove it, as needed.
            this.tbl_SKcandidatesTableAdapter.Fill(this.electionDatabaseDataSet23.tbl_SKcandidates);

        }
    }
}
