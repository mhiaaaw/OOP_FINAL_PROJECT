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
    public partial class UserLandingPage : Form
    {
        //SLIDER CONST
        private int ImageNumber = 1;

        


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
        public UserLandingPage()
        {
            InitializeComponent();
        }

        private void LoadNextImages() 
        {
            timer1.Start();
            ImageNumber++;

            if (ImageNumber > 6)
            {
                ImageNumber = 1;
            }

            sliders.ImageLocation = string.Format(@"C:\\Users\\Roly Baguanga\\source\\repos\\E-BOTO\\E-BOTO\\SliderImages\\"+ ImageNumber + ".png");
            LoadChecked();
        }

        private void LoadPreviousImages()
        {
            timer1.Start();
            ImageNumber--;

            if (ImageNumber < 1)
            {
                ImageNumber = 6;
            }

            sliders.ImageLocation = string.Format(@"C:\\Users\\Roly Baguanga\\source\\repos\\E-BOTO\\E-BOTO\\SliderImages\\" + ImageNumber + ".png");
            LoadChecked();
        }

        public void LoadChecked() 
        {
            if (ImageNumber == 1) { radioButton1.Checked = true; }
            else if (ImageNumber == 2) { radioButton2.Checked = true; }
            else if (ImageNumber == 3) { radioButton3.Checked = true; }
            else if (ImageNumber == 4) { radioButton4.Checked = true; }
            else if (ImageNumber == 5) { radioButton5.Checked = true; }
            else if (ImageNumber == 6) { radioButton6.Checked = true; }
        }

        public void ChangedCheck() 
        {
            timer1.Start();
            if (radioButton1.Checked == true) { ImageNumber = 1; }
            else if (radioButton2.Checked == true) { ImageNumber = 2; }
            else if (radioButton3.Checked == true) { ImageNumber = 3; }
            else if (radioButton4.Checked == true) { ImageNumber = 4; }
            else if (radioButton5.Checked == true) { ImageNumber = 5; }
            else if (radioButton6.Checked == true) { ImageNumber = 6; }

            sliders.ImageLocation = string.Format(@"C:\\Users\\Roly Baguanga\\source\\repos\\E-BOTO\\E-BOTO\\SliderImages\\" + ImageNumber + ".png");

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
            private void UserLandingPage_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            sliders.ImageLocation = string.Format(@"C:\\Users\\Roly Baguanga\\source\\repos\\E-BOTO\\E-BOTO\\SliderImages\\" + ImageNumber + ".png");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Votebtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminLogin AdminLogins = new AdminLogin();
                AdminLogins.Show();
                this.Hide();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserVote UserVotes = new UserVote();    
            UserVotes.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPreviousImages();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImages();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            ChangedCheck();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Votersbtn_Click(object sender, EventArgs e)
        {
            UserCandidates UserCandidates = new UserCandidates();
            UserCandidates.Show();
            this.Hide();
        }
    }
}
