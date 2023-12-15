using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_BOTO
{
    public partial class VoterDelete : Form
    {
        public VoterDelete()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            VotersCRUD votersCRUD = new VotersCRUD();
            votersCRUD.Show();
            this.Hide();
        }

        private void Candidatesbtn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=VotersDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string deleteQuery = "DELETE Voter WHERE ID=@ID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ID", Vdeletetb.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Deleted!");

                    // If Bindingdata() is a method that binds data to a control, call it here
                    // Bindingdata();

                    VotersCRUD VotersCRUDs = new VotersCRUD();
                    VotersCRUDs.Show();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VoterDelete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votersDatabaseDataSet7.Voter' table. You can move, or remove it, as needed.
            this.voterTableAdapter.Fill(this.votersDatabaseDataSet7.Voter);

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminLogin AdminLogins = new AdminLogin();
                AdminLogins.Show();
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
