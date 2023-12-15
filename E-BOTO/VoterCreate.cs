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
    public partial class VoterCreate : Form
    {
        public VoterCreate()
        {
            InitializeComponent();
        }

        private void Candidates_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            VotersCRUD votersCRUD = new VotersCRUD();
            votersCRUD.Show();
            this.Hide();
        }

        private void VoterCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votersDatabaseDataSet6.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter1.Fill(this.votersDatabaseDataSet6.Voter);
            //// TODO: This line of code loads data into the 'votersDatabaseDataSet4.Voters' table. You can move, or remove it, as needed.
            //this.votersTableAdapter.Fill(this.votersDatabaseDataSet4.Voters);
            //// TODO: This line of code loads data into the 'votersDatabaseDataSet1.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter.Fill(this.votersDatabaseDataSet1.Voter);
            //// TODO: This line of code loads data into the 'votersDatabaseDataSet.tbl_Voter' table. You can move, or remove it, as needed.
            //this.tbl_VoterTableAdapter.Fill(this.votersDatabaseDataSet.tbl_Voter);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fullnameTb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO Voterss (Precint, Name, Sex, Birthday, Address) VALUES (@Precint, @Name, @Sex, @Birthday, @Address)";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@Precint", Vprecint.Text);
                        command.Parameters.AddWithValue("@Name", VfullnameTb.Text);
                        command.Parameters.AddWithValue("@Sex", Vsex.Text);
                        command.Parameters.AddWithValue("@Birthday", VdateTimePicker1.Text);
                        command.Parameters.AddWithValue("@Address", Vaddress.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Inserted Voter");
                    // If Bindingdata() is a method that binds data to a control, call it here
                    // Bindingdata();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Votersbtn_Click(object sender, EventArgs e)
        {

        }

        private void Candidatesbtn_Click(object sender, EventArgs e)
        {
            Candicacy candicacy = new Candicacy();
            candicacy.Show();
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
        private void Votes_Click(object sender, EventArgs e)
        {
            Votes votes = new Votes();
            votes.Show();
            this.Hide();
        }

        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void VfullnameTb_Enter(object sender, EventArgs e)
        {
            if (VfullnameTb.Text == "Enter full name...")
            {
                VfullnameTb.Text = "";
                VfullnameTb.ForeColor = System.Drawing.SystemColors.ControlText; // Set text color to default
            }
        }

        private void VfullnameTb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VfullnameTb.Text))
            {
                VfullnameTb.Text = "Enter full name...";
                VfullnameTb.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder text color
            }
        }

        private void Vage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vgender.DroppedDown = false;
        }

        private void Vaddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vaddress.DroppedDown = false;
        }
    }
}
