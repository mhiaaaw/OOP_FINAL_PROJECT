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
    public partial class AdminLogin : Form
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

        private const string usernameAdmin = "SKkaruhatan";
        private const string passwordAdmin = "SKkaruhatan123";
        public AdminLogin()
        {
            InitializeComponent();
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

        private void AdminLoginlbl_Click(object sender, EventArgs e)
        {

        }
        private void Usernamebtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Passwordbtn_Click(object sender, EventArgs e)
        {

        }
        private const int MaxUsernameLength = 20;
        private const int MaxPasswordLength = 20;
        private void PrecintFinderbtn_Click(object sender, EventArgs e)
        {
            string inputUsername = Ausernametb.Text;
            string inputPassword = Apasswortb.Text;

            // Check if the input exceeds the maximum allowed length
            if (inputUsername.Length > MaxUsernameLength || inputPassword.Length > MaxPasswordLength)
            {
                MessageBox.Show("Username or password exceeds the maximum length of " + MaxUsernameLength + " characters.");
                return;
            }

            // Check if entered credentials match the admin credentials
            if (inputUsername == usernameAdmin && inputPassword == passwordAdmin)
            {
                AdminDashb adminDashb = new AdminDashb();
                adminDashb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again!");
            }

        }

        private void Apasswortb_TextChanged(object sender, EventArgs e)
        {
            if (Apasswortb.Text.Length >= MaxPasswordLength)
            {
                MessageBox.Show("Maximum password length reached (" + MaxPasswordLength + " characters).");
            }
        }

        private void Ausernametb_TextChanged(object sender, EventArgs e)
        {
            if (Ausernametb.Text.Length >= MaxUsernameLength)
            {
                MessageBox.Show("Maximum username length reached (" + MaxUsernameLength + " characters).");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 Form1s = new Form1();
            Form1s.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LoginContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel2_MouseDown(object sender, MouseEventArgs e)
        {
            Apasswortb.UseSystemPasswordChar = false;
        }

        private void linkLabel2_MouseUp(object sender, MouseEventArgs e)
        {
            Apasswortb.UseSystemPasswordChar = true;
        }
    }
}
