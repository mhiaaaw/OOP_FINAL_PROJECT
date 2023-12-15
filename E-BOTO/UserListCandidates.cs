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
    public partial class UserListCandidates : Form
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
        public UserListCandidates()
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
            private void label1_Click(object sender, EventArgs e)
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
    }
}
