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
    public partial class VoterUpdate : Form
    {
        public VoterUpdate()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            VotersCRUD votersCRUD = new VotersCRUD();
            votersCRUD.Show();
            this.Hide();
        }

        private void VoterUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet22.Voterss' table. You can move, or remove it, as needed.
            this.voterssTableAdapter.Fill(this.electionDatabaseDataSet22.Voterss);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet20.Voters' table. You can move, or remove it, as needed.
            //this.votersTableAdapter.Fill(this.electionDatabaseDataSet20.Voters);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet18.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter2.Fill(this.electionDatabaseDataSet18.Voter);
            // TODO: This line of code loads data into the 'votersDatabaseDataSet9.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter1.Fill(this.votersDatabaseDataSet9.Voter);
            // TODO: This line of code loads data into the 'votersDatabaseDataSet6.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter.Fill(this.votersDatabaseDataSet6.Voter);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void Vupdate_Click(object sender, EventArgs e)
        //{
        //    string connectionString = "Data Source=MIYA;Initial Catalog=VotersDatabase;Integrated Security=True";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();

        //            string insertQuery = "UPDATE Voter SET Precint=@Precint, Name=@Name, Sex=@Sex, Birthday=@Birthday, Address=@Address WHERE ID=@ID";

        //            using (SqlCommand command = new SqlCommand(insertQuery, conn))
        //            {
        //                // Use parameters to avoid SQL injection
        //                command.Parameters.AddWithValue("@Precint", Vprecint.Text);
        //                command.Parameters.AddWithValue("@Name", VfullnameTb.Text);
        //                command.Parameters.AddWithValue("@Sex", Vgender.Text);
        //                command.Parameters.AddWithValue("@Birthday", VdateTimePicker1.Text);
        //                command.Parameters.AddWithValue("@Address", Vaddress.Text);

        //                command.ExecuteNonQuery();
        //            }

        //            MessageBox.Show("Successfully Update!");

        //            // If Bindingdata() is a method that binds data to a control, call it here
        //            // Bindingdata();

        //            VotersCRUD VotersCRUDs = new VotersCRUD();
        //            VotersCRUDs.Show();

        //            this.Hide();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}");
        //        }
        //    }
        //}

        private void Vupdate_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string updateQuery = "UPDATE Voterss SET Precint=@Precint, Name=@Name, Sex=@Sex, Birthday=@Birthday, Address=@Address WHERE ID=@ID";

                        using (SqlCommand command = new SqlCommand(updateQuery, conn))
                        {
                            // Use parameters to avoid SQL injection
                            command.Parameters.AddWithValue("@ID", dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);
                            command.Parameters.AddWithValue("@Precint", Vprecint.Text);
                            command.Parameters.AddWithValue("@Name", VfullnameTb.Text);
                            command.Parameters.AddWithValue("@Sex", Vgender.Text);
                            command.Parameters.AddWithValue("@Birthday", VdateTimePicker1.Text);
                            command.Parameters.AddWithValue("@Address", Vaddress.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Successfully Updated!");

                        // Get the DataGridView from Candicacy form
                        VotersCRUD VotersCRUDs = new VotersCRUD();
                        DataGridView dataGridViewFromVoter = VotersCRUDs.GetDataGridView();

                        // Do something with dataGridViewFromCandicacy if needed

                        VotersCRUDs.Show();

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



        //private void Vupdate_Click(object sender, EventArgs e)
        //{
        //    // Check if a row is selected in the DataGridView
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

        //        string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            try
        //            {
        //                conn.Open();

        //                string updateQuery = "UPDATE tbl_SKcandidates SET Image=@Image, Name=@Name, Position=@Position, PartyList=@PartyList WHERE ID=@ID";

        //                using (SqlCommand command = new SqlCommand(updateQuery, conn))
        //                {
        //                    // Use parameters to avoid SQL injection
        //                    command.Parameters.AddWithValue("@ID", dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);
        //                    command.Parameters.AddWithValue("@Image", updatepic.Text);
        //                    command.Parameters.AddWithValue("@Name", updatename.Text);
        //                    command.Parameters.AddWithValue("@Position", updateposition.Text);
        //                    command.Parameters.AddWithValue("@PartyList", updatepartylist.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //                MessageBox.Show("Successfully Updated!");

        //                // If Bindingdata() is a method that binds data to a control, call it here
        //                // Bindingdata();

        //                Candicacy candicacys = new Candicacy();
        //                candicacys.Show();

        //                this.Hide();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void Candidatesbtn_Click(object sender, EventArgs e)
        //{
        //    Candicacy candicacy = new Candicacy();  
        //    candicacy.Show();
        //    this.Hide();
        //}

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminLogin AdminLogins = new AdminLogin();
                AdminLogins.Show();
                this.Hide();

            }
        }

        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
        }

        private void Votes_Click(object sender, EventArgs e)
        {
            Votes votes = new Votes();
            votes.Show();
            this.Hide();
        }
        private void UVdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UVfullnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void UVid_TextChanged(object sender, EventArgs e)
        {

        }

        private void UVsex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
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

                        string updateQuery = "UPDATE Voterss SET Precint=@Precint, Name=@Name, Sex=@Sex, Birthday=@Birthday, Address=@Address WHERE ID=@ID";

                        using (SqlCommand command = new SqlCommand(updateQuery, conn))
                        {
                            // Use parameters to avoid SQL injection
                            command.Parameters.AddWithValue("@ID", selectedRow["ID"]);
                            command.Parameters.AddWithValue("@Precint", Vprecint.Text);
                            command.Parameters.AddWithValue("@Name", VfullnameTb.Text);
                            command.Parameters.AddWithValue("@Sex", Vgender.Text);
                            command.Parameters.AddWithValue("@Birthday", VdateTimePicker1.Text);
                            command.Parameters.AddWithValue("@Address", Vaddress.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Successfully Updated!");

                        // Get the DataGridView from VotersCRUD form
                        VotersCRUD VotersCRUDs = new VotersCRUD();
                        DataGridView dataGridViewFromVoter = VotersCRUDs.GetDataGridView();

                        // Do something with dataGridViewFromVotersCRUD if needed

                        VotersCRUDs.Show();

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

    }
}
    
