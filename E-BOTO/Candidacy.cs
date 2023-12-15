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
    public partial class Candicacy : Form
    {
        private List<string> precinctData = new List<string>();
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
        public Candicacy()
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
        private void Create_Click(object sender, EventArgs e)
        {
            CandidateCreate CandidateCreates = new CandidateCreate();
            CandidateCreates.ShowDialog();
        }

        private void Candicacy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet24.tbl_SKcandidate' table. You can move, or remove it, as needed.
            this.tbl_SKcandidateTableAdapter.Fill(this.electionDatabaseDataSet24.tbl_SKcandidate);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet14.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter7.Fill(this.electionDatabaseDataSet14.tbl_SKcandidates);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet13.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter6.Fill(this.electionDatabaseDataSet13.tbl_SKcandidates);
            //// TODO: This line of code loads data into the 'electionDatabaseDataSet12.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter5.Fill(this.electionDatabaseDataSet12.tbl_SKcandidates);
            //// TODO: This line of code loads data into the 'electionDatabaseDataSet11.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter4.Fill(this.electionDatabaseDataSet11.tbl_SKcandidates);
            //// TODO: This line of code loads data into the 'electionDatabaseDataSet9.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter3.Fill(this.electionDatabaseDataSet9.tbl_SKcandidates);


        }

        //public void RefreshDataGridView()
        //{
        //    // Refresh the data in the DataGridView
        //    this.tbl_SKcandidatesTableAdapter7.Fill(this.electionDatabaseDataSet14.tbl_SKcandidates);
        //}

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

                            string deleteQuery = "DELETE FROM tbl_SKcandidate WHERE ID=@ID";
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


        private void Search_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "Select * FROM tbl_SKcandidate WHERE ID=@ID,  Name=@Name";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ID", Csearchtb.Text);
                        command.Parameters.AddWithValue("@Name", Csearchtb.Text);
                        command.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Input Invalid");
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Candicacy Candicacys = new Candicacy();
            Candicacys.Show();

            this.Hide();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            CandidateUpdate CandidateUpdates = new CandidateUpdate();
            CandidateUpdates.Show();
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

        private void searchtb_TextChanged(object sender, EventArgs e)
        {

        }
        private void Vsearchtb_TextChanged(object sender, EventArgs e)
        {

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

        private void Votersbtn_Click_1(object sender, EventArgs e)
        {
            VotersCRUD votersCRUD = new VotersCRUD();
            votersCRUD.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Votes votes = new Votes();
            votes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void CSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string selectQuery = "SELECT * FROM tbl_SKcandidate WHERE ID=@ID";

                    using (SqlCommand command = new SqlCommand(selectQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ID", Csearchtb.Text);

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
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }



        private void PopulateComboBox()
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";
            string query = "SELECT Name FROM tbl_SKcandidate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string value = reader["Name"].ToString();
                                precinctData.Add(value); // Store the corresponding value
                                gunaComboBox2.Items.Add(value);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in PopulateComboBox: {ex.Message}");
                    }
                }
            }
        }


        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = gunaComboBox2.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < precinctData.Count)
            {
                string selectedName = precinctData[selectedIndex];
                DisplayDataInDataGridView(selectedName);
            }
        }

        private void DisplayDataInDataGridView(string selectedName)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";
            string query = "SELECT * FROM tbl_SKcandidate WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", selectedName);

                    try
                    {
                        connection.Open();

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Ensure the DataTable is cleared before filling
                        dataTable.Clear();

                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in DisplayDataInDataGridView: {ex.Message}");
                    }
                }
            }
        }

    }
}
