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
    public partial class VotersCRUD : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        bool drag = false;
        Point startingpoint = new Point(0, 0);
        public VotersCRUD()
        {
            InitializeComponent();
        }

        public DataGridView GetDataGridView()
        {
            return dataGridView1;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
            {
                int resizeBorderWidth = 10; // Width of the border for resizing

                Point cursor = this.PointToClient(Cursor.Position);

                if (cursor.X <= resizeBorderWidth && cursor.Y <= resizeBorderWidth)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X >= this.ClientSize.Width - resizeBorderWidth && cursor.Y <= resizeBorderWidth)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X <= resizeBorderWidth && cursor.Y >= this.ClientSize.Height - resizeBorderWidth)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X >= this.ClientSize.Width - resizeBorderWidth && cursor.Y >= this.ClientSize.Height - resizeBorderWidth)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X <= resizeBorderWidth)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X >= this.ClientSize.Width - resizeBorderWidth)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y <= resizeBorderWidth)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y >= this.ClientSize.Height - resizeBorderWidth)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }
        private void VotersCRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet21.Voterss' table. You can move, or remove it, as needed.
            this.voterssTableAdapter.Fill(this.electionDatabaseDataSet21.Voterss);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet19.Voters' table. You can move, or remove it, as needed.
            //this.votersTableAdapter1.Fill(this.electionDatabaseDataSet19.Voters);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet17.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter5.Fill(this.electionDatabaseDataSet17.Voter);
            // TODO: This line of code loads data into the 'votersDatabaseDataSet11.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter4.Fill(this.votersDatabaseDataSet11.Voter);
            // TODO: This line of code loads data into the 'votersDatabaseDataSet10.Voter' table. You can move, or remove it, as needed.
            //    this.voterTableAdapter3.Fill(this.votersDatabaseDataSet10.Voter);
            //    // TODO: This line of code loads data into the 'votersDatabaseDataSet8.Voter' table. You can move, or remove it, as needed.
            //    this.voterTableAdapter2.Fill(this.votersDatabaseDataSet8.Voter);
            //    // TODO: This line of code loads data into the 'votersDatabaseDataSet5.Voter' table. You can move, or remove it, as needed.
            //    this.voterTableAdapter1.Fill(this.votersDatabaseDataSet5.Voter);
            //    //// TODO: This line of code loads data into the 'votersDatabaseDataSet3.Voters' table. You can move, or remove it, as needed.
            //    this.votersTableAdapter.Fill(this.votersDatabaseDataSet3.Voters);
            //    //// TODO: This line of code loads data into the 'votersDatabaseDataSet2.Voter' table. You can move, or remove it, as needed.
            //    this.voterTableAdapter.Fill(this.votersDatabaseDataSet2.Voter);
            //    //// TODO: This line of code loads data into the 'votersDatabaseDataSet.tbl_Voter' table. You can move, or remove it, as needed.
            //this.tbl_VoterTableAdapter.Fill(this.votersDatabaseDataSet.tbl_Voter);

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "Select * FROM Voterss WHERE ID=@ID";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ID", Vsearchtb.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given ID.");
                        }
                    }
                }
                catch (Exception)                                    
                {
                    MessageBox.Show("Input Invalid");
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            using (VoterCreate VoterCreates = new VoterCreate())
            {
                // Show the form as a dialog
                this.Enabled = false; // Disable the main form while the pop-up is shown
                VoterCreates.ShowDialog(); // Show the pop-up form as a dialog

                // Enable the main form when the pop-up form is closed
                this.Enabled = true;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //using (VoterUpdate VoterCreates = new VoterUpdate())
            //{
            //    // Show the form as a dialog
            //    this.Enabled = false; // Disable the main form while the pop-up is shown
            //    VoterCreates.ShowDialog(); // Show the pop-up form as a dialog

            //    // Enable the main form when the pop-up form is closed
            //    this.Enabled = true;
            //}

            VoterUpdate VoterUpdates = new VoterUpdate();
            VoterUpdates.Show();
            this.Hide();
        }

        private void Candidatesbtn_Click(object sender, EventArgs e)
        {
            Candicacy candicacy = new Candicacy();
            candicacy.Show();
            this.Hide();
        }

        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                if (MessageBox.Show("Confirm delete?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Assuming your DataGridView has a column with an integer value
                    int idToDelete = -1;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.DataPropertyName == "ID" && dataGridView1.Rows[selectedRowIndex].Cells[column.Index].Value != null)
                        {
                            if (int.TryParse(dataGridView1.Rows[selectedRowIndex].Cells[column.Index].Value.ToString(), out idToDelete))
                            {
                                break; // Found the column, exit the loop
                            }
                        }
                    }

                    if (idToDelete != -1)
                    {
                        // Now, you can delete the corresponding data from your database
                        string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM Voterss WHERE ID=@ID";
                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ID", idToDelete);
                                command.ExecuteNonQuery();
                            }
                        }

                        dataGridView1.Rows.RemoveAt(selectedRowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not have a valid integer ID.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            VotersCRUD VotersCRUDs = new VotersCRUD();
            VotersCRUDs.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Votes_Click(object sender, EventArgs e)
        {
            Votes Votes = new Votes();
            Votes.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startingpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startingpoint.X, p.Y - startingpoint.Y);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void Logoutbtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminLogin AdminLogins = new AdminLogin();
                AdminLogins.Show();
                this.Hide();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
        }

        private void Candidatesbtn_Click_1(object sender, EventArgs e)
        {
            Candicacy c = new Candicacy();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Votes votes = new Votes();
            votes.Show();
            this.Hide();
        }

        private void SideNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Candidates_Click(object sender, EventArgs e)
        {

        }

        private void Vsearchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
