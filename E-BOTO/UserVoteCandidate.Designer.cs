namespace E_BOTO
{
    partial class UserVoteCandidate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Positionlbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Candidates = new System.Windows.Forms.Label();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.Vsearchtb = new System.Windows.Forms.TextBox();
            this.SideNav = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Button();
            this.CandidatesListbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Votes = new System.Windows.Forms.Button();
            this.Overviewbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Vote = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelNavbar.SuspendLayout();
            this.SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Controls.Add(this.Refresh);
            this.panel2.Controls.Add(this.Vote);
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Positionlbl);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(318, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 779);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(907, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "Vote Left:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(992, 399);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(908, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 59);
            this.textBox1.TabIndex = 2;
            // 
            // Positionlbl
            // 
            this.Positionlbl.AutoSize = true;
            this.Positionlbl.Font = new System.Drawing.Font("Helvetica", 12F);
            this.Positionlbl.ForeColor = System.Drawing.Color.White;
            this.Positionlbl.Location = new System.Drawing.Point(43, 71);
            this.Positionlbl.Name = "Positionlbl";
            this.Positionlbl.Size = new System.Drawing.Size(103, 28);
            this.Positionlbl.TabIndex = 1;
            this.Positionlbl.Text = "Position:";
            this.Positionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(411, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "User";
            // 
            // Candidates
            // 
            this.Candidates.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidates.Location = new System.Drawing.Point(32, 42);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(243, 51);
            this.Candidates.TabIndex = 0;
            this.Candidates.Text = "Voters";
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.White;
            this.panelNavbar.Controls.Add(this.Candidates);
            this.panelNavbar.Controls.Add(this.Search);
            this.panelNavbar.Controls.Add(this.Vsearchtb);
            this.panelNavbar.Location = new System.Drawing.Point(299, -1);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1120, 140);
            this.panelNavbar.TabIndex = 34;
            // 
            // Vsearchtb
            // 
            this.Vsearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Vsearchtb.Location = new System.Drawing.Point(535, 42);
            this.Vsearchtb.Multiline = true;
            this.Vsearchtb.Name = "Vsearchtb";
            this.Vsearchtb.Size = new System.Drawing.Size(353, 58);
            this.Vsearchtb.TabIndex = 24;
            this.Vsearchtb.Text = " ";
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.SideNav.Controls.Add(this.CandidatesListbtn);
            this.SideNav.Controls.Add(this.label1);
            this.SideNav.Controls.Add(this.Logoutbtn);
            this.SideNav.Controls.Add(this.pictureBox3);
            this.SideNav.Controls.Add(this.Votes);
            this.SideNav.Controls.Add(this.Overviewbtn);
            this.SideNav.Location = new System.Drawing.Point(0, -1);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(300, 970);
            this.SideNav.TabIndex = 35;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Image = global::E_BOTO.Properties.Resources.icons8_search_302;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(893, 42);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Search.Size = new System.Drawing.Size(200, 58);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // CandidatesListbtn
            // 
            this.CandidatesListbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.CandidatesListbtn.FlatAppearance.BorderSize = 0;
            this.CandidatesListbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CandidatesListbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidatesListbtn.ForeColor = System.Drawing.Color.White;
            this.CandidatesListbtn.Image = global::E_BOTO.Properties.Resources.icons8_vote_30__2_;
            this.CandidatesListbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CandidatesListbtn.Location = new System.Drawing.Point(3, 455);
            this.CandidatesListbtn.Name = "CandidatesListbtn";
            this.CandidatesListbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.CandidatesListbtn.Size = new System.Drawing.Size(294, 60);
            this.CandidatesListbtn.TabIndex = 46;
            this.CandidatesListbtn.Text = "       Voted List";
            this.CandidatesListbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CandidatesListbtn.UseVisualStyleBackColor = false;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.FlatAppearance.BorderSize = 0;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Image = global::E_BOTO.Properties.Resources.icons8_logout_30__1_;
            this.Logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.Location = new System.Drawing.Point(3, 869);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Logoutbtn.Size = new System.Drawing.Size(297, 60);
            this.Logoutbtn.TabIndex = 38;
            this.Logoutbtn.Text = "       Log out";
            this.Logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(75, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // Votes
            // 
            this.Votes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Votes.FlatAppearance.BorderSize = 0;
            this.Votes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Votes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Votes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Votes.Image = global::E_BOTO.Properties.Resources.icons8_ballot_304;
            this.Votes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votes.Location = new System.Drawing.Point(3, 388);
            this.Votes.Name = "Votes";
            this.Votes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Votes.Size = new System.Drawing.Size(294, 60);
            this.Votes.TabIndex = 43;
            this.Votes.Text = "       Vote";
            this.Votes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votes.UseVisualStyleBackColor = false;
            // 
            // Overviewbtn
            // 
            this.Overviewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Overviewbtn.FlatAppearance.BorderSize = 0;
            this.Overviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Overviewbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overviewbtn.ForeColor = System.Drawing.Color.White;
            this.Overviewbtn.Image = global::E_BOTO.Properties.Resources.icons8_overview_301;
            this.Overviewbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Overviewbtn.Location = new System.Drawing.Point(3, 322);
            this.Overviewbtn.Name = "Overviewbtn";
            this.Overviewbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Overviewbtn.Size = new System.Drawing.Size(294, 60);
            this.Overviewbtn.TabIndex = 37;
            this.Overviewbtn.Text = "       Dashboard";
            this.Overviewbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Overviewbtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Image = global::E_BOTO.Properties.Resources.icons8_back_302;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.Location = new System.Drawing.Point(821, 693);
            this.backbtn.Name = "backbtn";
            this.backbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.backbtn.Size = new System.Drawing.Size(200, 58);
            this.backbtn.TabIndex = 50;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Image = global::E_BOTO.Properties.Resources.icons8_refresh_30;
            this.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refresh.Location = new System.Drawing.Point(831, 164);
            this.Refresh.Name = "Refresh";
            this.Refresh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Refresh.Size = new System.Drawing.Size(200, 58);
            this.Refresh.TabIndex = 40;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // Vote
            // 
            this.Vote.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vote.Image = global::E_BOTO.Properties.Resources.icons8_vote_30;
            this.Vote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vote.Location = new System.Drawing.Point(42, 164);
            this.Vote.Name = "Vote";
            this.Vote.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Vote.Size = new System.Drawing.Size(200, 58);
            this.Vote.TabIndex = 37;
            this.Vote.Text = "Vote";
            this.Vote.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Image = global::E_BOTO.Properties.Resources.icons8_profile_30;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(250, 164);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Update.Size = new System.Drawing.Size(200, 58);
            this.Update.TabIndex = 38;
            this.Update.Text = "View Profile";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // UserVoteCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserVoteCandidate";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            this.SideNav.ResumeLayout(false);
            this.SideNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Positionlbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Vote;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Overviewbtn;
        private System.Windows.Forms.Label Candidates;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Vsearchtb;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button Votes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CandidatesListbtn;
    }
}