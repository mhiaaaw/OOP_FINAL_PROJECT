using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Net.WebRequestMethods;

namespace E_BOTO
{
    
    public partial class UserVote : Form
    {
        private const string ConnectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";
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
        public UserVote()
        {
            InitializeComponent();
            LoadCandidates();
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startingpoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startingpoint.X, p.Y - startingpoint.Y);

            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadCandidates()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Assuming you have a table named SKCandidates with columns ID, Name, and Votes
                    string query = "SELECT image, ID, Name, Position, Partylist, Votes FROM tbl_SKcandidates";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable candidatesTable = new DataTable();
                    adapter.Fill(candidatesTable);

                    // Create a ComboBox to display candidates
                    ComboBox comboBoxCandidates = new ComboBox();
                    comboBoxCandidates.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxCandidates.DisplayMember = "Name";
                    comboBoxCandidates.ValueMember = "ID";
                    comboBoxCandidates.DataSource = candidatesTable;
                    flowLayoutPanel1.Controls.Add(comboBoxCandidates);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading candidates: " + ex.Message);
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a candidate before voting.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ComboBox selectedComboBox = flowLayoutPanel1.Controls.OfType<ComboBox>().FirstOrDefault();

            if (selectedComboBox != null && selectedComboBox.SelectedItem != null)
            {
                if (int.TryParse(selectedComboBox.SelectedValue?.ToString(), out int selectedCandidateId))
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Update the vote count
                            string updateQuery = "UPDATE tbl_SKcandidates SET Votes = Votes + 1 WHERE ID = @ID";
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ID", selectedCandidateId);
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Vote cast successfully!");

                            // Reload candidates after the vote is cast
                            flowLayoutPanel1.Controls.Clear(); // Clear existing controls
                            LoadCandidates();

                            UserLandingPage userLandingPage = new UserLandingPage();
                            userLandingPage.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating vote count: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unable to convert selected value to CandidateId.");
                }
            }
            else
            {
                MessageBox.Show("Please select a candidate before voting.");
            }
        }

        private void UserVote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet15.tbl_SKcandidates' table. You can move, or remove it, as needed.
            this.tbl_SKcandidatesTableAdapter.Fill(this.electionDatabaseDataSet15.tbl_SKcandidates);
        }

    }
}

