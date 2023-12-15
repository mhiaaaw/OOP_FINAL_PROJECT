using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace E_BOTO
{
    public partial class CandidateCreate : Form
    {
        public CandidateCreate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if an image is selected
                    if (string.IsNullOrEmpty(pictureBox1.ImageLocation))
                    {
                        MessageBox.Show("Please upload an image.");
                        return;
                    }

                    // Convert the image to bytes
                    byte[] imageData = File.ReadAllBytes(pictureBox1.ImageLocation);

                    string insertQuery = "INSERT INTO tbl_SKcandidate (Image, Name, Position, PartyList) VALUES (@Image, @Name, @Position, @PartyList)";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@Image", imageData);
                        command.Parameters.AddWithValue("@Name", fullnameTb.Text);
                        command.Parameters.AddWithValue("@Position", positiontb.Text);
                        command.Parameters.AddWithValue("@PartyList", partylisttb.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Inserted");

                    // Refresh the DataGridView in the Candicacy form
                    Candicacy candicacyForm = new Candicacy();
                    //candicacyForm.RefreshDataGridView();

                    // Close the current form
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void CandidateCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet6.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter1.Fill(this.electionDatabaseDataSet6.tbl_SKcandidates);
            //// TODO: This line of code loads data into the 'electionDatabaseDataSet3.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter.Fill(this.electionDatabaseDataSet3.tbl_SKcandidates);
            //// TODO: This line of code loads data into the 'electionDatabaseDataSet.Candidates' table. You can move, or remove it, as needed.
            //this.candidatesTableAdapter.Fill(this.electionDatabaseDataSet.Candidates);

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void partylisttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void positiontb_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void CandidateUpdatelbl_Click(object sender, EventArgs e)
        {

        }

        private void Candidates_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Votes_Click(object sender, EventArgs e)
        {
            Votes votes = new Votes();
            votes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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


        private void positiontb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }


}

