using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_BOTO
{
    public partial class CandidateUpdate : Form
    {
        public CandidateUpdate()
        {
            InitializeComponent();
        }

        private void CandidateUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet25.tbl_SKcandidate' table. You can move, or remove it, as needed.
            this.tbl_SKcandidateTableAdapter.Fill(this.electionDatabaseDataSet25.tbl_SKcandidate);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet10.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter1.Fill(this.electionDatabaseDataSet10.tbl_SKcandidates);


        }

        private void Add_Click(object sender, EventArgs e)
        {
            
        }

 

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Candicacy Candicacys = new Candicacy();
            Candicacys.Show();

            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            AdminDashb dashboard = new AdminDashb();
            dashboard.Show();
            this.Hide();
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

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminLogin AdminLogins = new AdminLogin();
                AdminLogins.Show();
                this.Hide();

            }
        }

        private void Updatepartylist_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                // Assuming your DataGridView is bound to a DataTable
                DataRowView selectedRow = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

                string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string updateQuery = "UPDATE tbl_SKcandidate SET Image=@Image, Name=@Name, Position=@Position, PartyList=@PartyList WHERE ID=@ID";

                        using (SqlCommand command = new SqlCommand(updateQuery, conn))
                        {
                            // Use parameters to avoid SQL injection
                            command.Parameters.AddWithValue("@ID", selectedRow["ID"]);
                            command.Parameters.AddWithValue("@Image", uploadpic.Text);
                            command.Parameters.AddWithValue("@Name", updatename.Text);
                            command.Parameters.AddWithValue("@Position", updateposition.Text);
                            command.Parameters.AddWithValue("@PartyList", updatepartylist.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Successfully Updated!");

                        // Get the DataGridView from VotersCRUD form
                        Candicacy Candicacys = new Candicacy();
                        DataGridView dataGridViewFromVoter = Candicacys.GetDataGridView();

                        // Do something with dataGridViewFromVotersCRUD if needed

                        Candicacys.Show();

                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uploadC_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files |*.jpg; *.jpeg; *.png; *.gif; *.bmp;",
                Title = "Select an Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imageLocation = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;

                    // Optionally, you can store the path or image data for further processing
                    // string imagePath = imageLocation;
                    // byte[] imageData = File.ReadAllBytes(imageLocation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
