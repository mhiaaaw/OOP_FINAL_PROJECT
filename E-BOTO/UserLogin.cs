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
    public partial class UserLogin : Form
    {
        private const string ConnectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";
        public UserLogin()
        {
            InitializeComponent();
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void AdminLoginlbl_Click_1(object sender, EventArgs e)
        {

        }

        private void PrecintFinderbtn_Click(object sender, EventArgs e)
        {
            UserLandingPage userLandingPage = new UserLandingPage();
            userLandingPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1s = new Form1();
            Form1s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 Form1s = new Form1();
            Form1s.Show();
            this.Hide();
        }

        private const int MaxUsernameLength = 20;
        private const int MaxPasswordLength = 20;
        private void PrecintFinderbtn_Click_1(object sender, EventArgs e)
        {
            string username = Ausernametb.Text;
            string password = Apasswortb.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Check login credentials
                    string query = "SELECT COUNT(*) FROM user_accounts WHERE Username=@Username AND Password=@Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            UserLandingPage UserLandingPages = new UserLandingPage();
                            UserLandingPages.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
