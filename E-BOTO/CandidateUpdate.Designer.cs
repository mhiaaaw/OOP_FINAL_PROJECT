namespace E_BOTO
{
    partial class CandidateUpdate
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
            this.components = new System.ComponentModel.Container();
            this.tblSKcandidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet4 = new E_BOTO.ElectionDatabaseDataSet4();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet = new E_BOTO.ElectionDatabaseDataSet();
            this.updateposition = new System.Windows.Forms.ComboBox();
            this.updatepartylist = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.candidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter();
            this.tbl_SKcandidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSet4TableAdapters.tbl_SKcandidatesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.updatename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voterTableAdapter = new E_BOTO.VotersDatabaseDataSet6TableAdapters.VoterTableAdapter();
            this.votersDatabaseDataSet6 = new E_BOTO.VotersDatabaseDataSet6();
            this.votersDatabaseDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uploadpic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblSKcandidatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet10 = new E_BOTO.ElectionDatabaseDataSet10();
            this.tbl_SKcandidatesTableAdapter1 = new E_BOTO.ElectionDatabaseDataSet10TableAdapters.tbl_SKcandidatesTableAdapter();
            this.electionDatabaseDataSet25 = new E_BOTO.ElectionDatabaseDataSet25();
            this.tblSKcandidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SKcandidateTableAdapter = new E_BOTO.ElectionDatabaseDataSet25TableAdapters.tbl_SKcandidateTableAdapter();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partylistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSKcandidatesBindingSource
            // 
            this.tblSKcandidatesBindingSource.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource.DataSource = this.electionDatabaseDataSet4;
            // 
            // electionDatabaseDataSet4
            // 
            this.electionDatabaseDataSet4.DataSetName = "ElectionDatabaseDataSet4";
            this.electionDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "Candidates";
            this.candidatesBindingSource.DataSource = this.electionDatabaseDataSet;
            // 
            // electionDatabaseDataSet
            // 
            this.electionDatabaseDataSet.DataSetName = "ElectionDatabaseDataSet";
            this.electionDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updateposition
            // 
            this.updateposition.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateposition.FormattingEnabled = true;
            this.updateposition.Items.AddRange(new object[] {
            "Chairman/Chairwoman",
            "Kagawad"});
            this.updateposition.Location = new System.Drawing.Point(38, 571);
            this.updateposition.Name = "updateposition";
            this.updateposition.Size = new System.Drawing.Size(309, 36);
            this.updateposition.TabIndex = 38;
            // 
            // updatepartylist
            // 
            this.updatepartylist.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepartylist.FormattingEnabled = true;
            this.updatepartylist.Items.AddRange(new object[] {
            "Party List A",
            "Party List B",
            "Party List C"});
            this.updatepartylist.Location = new System.Drawing.Point(357, 571);
            this.updatepartylist.Name = "updatepartylist";
            this.updatepartylist.Size = new System.Drawing.Size(185, 36);
            this.updatepartylist.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(354, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Party-List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Position:";
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SKcandidatesTableAdapter
            // 
            this.tbl_SKcandidatesTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1194, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 60;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updatename
            // 
            this.updatename.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatename.Location = new System.Drawing.Point(38, 498);
            this.updatename.Name = "updatename";
            this.updatename.Size = new System.Drawing.Size(500, 36);
            this.updatename.TabIndex = 47;
            this.updatename.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fullname: (Ex. Dela Cruz, Juan A.)";
            // 
            // voterTableAdapter
            // 
            this.voterTableAdapter.ClearBeforeFill = true;
            // 
            // votersDatabaseDataSet6
            // 
            this.votersDatabaseDataSet6.DataSetName = "VotersDatabaseDataSet6";
            this.votersDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersDatabaseDataSet6BindingSource
            // 
            this.votersDatabaseDataSet6BindingSource.DataSource = this.votersDatabaseDataSet6;
            this.votersDatabaseDataSet6BindingSource.Position = 0;
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataMember = "Voter";
            this.voterBindingSource.DataSource = this.votersDatabaseDataSet6BindingSource;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 37);
            this.label4.TabIndex = 73;
            this.label4.Text = "Candidate Information";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(165, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 47);
            this.label6.TabIndex = 72;
            this.label6.Text = "UPDATE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(197, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // Update
            // 
            this.Update.BackgroundImage = global::E_BOTO.Properties.Resources.bgbtn1;
            this.Update.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Image = global::E_BOTO.Properties.Resources.icons8_table_properties_302;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(188, 653);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Update.Size = new System.Drawing.Size(170, 57);
            this.Update.TabIndex = 55;
            this.Update.Text = "     Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // uploadpic
            // 
            this.uploadpic.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadpic.ForeColor = System.Drawing.Color.Black;
            this.uploadpic.Image = global::E_BOTO.Properties.Resources.icons8_add_new_30;
            this.uploadpic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadpic.Location = new System.Drawing.Point(325, 331);
            this.uploadpic.Name = "uploadpic";
            this.uploadpic.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.uploadpic.Size = new System.Drawing.Size(149, 55);
            this.uploadpic.TabIndex = 75;
            this.uploadpic.Text = "     Upload";
            this.uploadpic.UseVisualStyleBackColor = true;
            this.uploadpic.Click += new System.EventHandler(this.uploadC_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.partylistDataGridViewTextBoxColumn,
            this.votesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSKcandidateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(567, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(683, 458);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblSKcandidatesBindingSource1
            // 
            this.tblSKcandidatesBindingSource1.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource1.DataSource = this.electionDatabaseDataSet10;
            // 
            // electionDatabaseDataSet10
            // 
            this.electionDatabaseDataSet10.DataSetName = "ElectionDatabaseDataSet10";
            this.electionDatabaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_SKcandidatesTableAdapter1
            // 
            this.tbl_SKcandidatesTableAdapter1.ClearBeforeFill = true;
            // 
            // electionDatabaseDataSet25
            // 
            this.electionDatabaseDataSet25.DataSetName = "ElectionDatabaseDataSet25";
            this.electionDatabaseDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSKcandidateBindingSource
            // 
            this.tblSKcandidateBindingSource.DataMember = "tbl_SKcandidate";
            this.tblSKcandidateBindingSource.DataSource = this.electionDatabaseDataSet25;
            // 
            // tbl_SKcandidateTableAdapter
            // 
            this.tbl_SKcandidateTableAdapter.ClearBeforeFill = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 8;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 150;
            // 
            // partylistDataGridViewTextBoxColumn
            // 
            this.partylistDataGridViewTextBoxColumn.DataPropertyName = "Partylist";
            this.partylistDataGridViewTextBoxColumn.HeaderText = "Partylist";
            this.partylistDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partylistDataGridViewTextBoxColumn.Name = "partylistDataGridViewTextBoxColumn";
            this.partylistDataGridViewTextBoxColumn.Width = 150;
            // 
            // votesDataGridViewTextBoxColumn
            // 
            this.votesDataGridViewTextBoxColumn.DataPropertyName = "Votes";
            this.votesDataGridViewTextBoxColumn.HeaderText = "Votes";
            this.votesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.votesDataGridViewTextBoxColumn.Name = "votesDataGridViewTextBoxColumn";
            this.votesDataGridViewTextBoxColumn.Width = 150;
            // 
            // CandidateUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1281, 807);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uploadpic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.updatename);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateposition);
            this.Controls.Add(this.updatepartylist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateUpdate";
            this.Load += new System.EventHandler(this.CandidateUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private ElectionDatabaseDataSet electionDatabaseDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private ElectionDatabaseDataSet4 electionDatabaseDataSet4;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource;
        private ElectionDatabaseDataSet4TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter;
        private System.Windows.Forms.ComboBox updatepartylist;
        private System.Windows.Forms.ComboBox updateposition;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox updatename;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private VotersDatabaseDataSet6TableAdapters.VoterTableAdapter voterTableAdapter;
        private VotersDatabaseDataSet6 votersDatabaseDataSet6;
        private System.Windows.Forms.BindingSource votersDatabaseDataSet6BindingSource;
        private System.Windows.Forms.BindingSource voterBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uploadpic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ElectionDatabaseDataSet10 electionDatabaseDataSet10;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource1;
        private ElectionDatabaseDataSet10TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter1;
        private ElectionDatabaseDataSet25 electionDatabaseDataSet25;
        private System.Windows.Forms.BindingSource tblSKcandidateBindingSource;
        private ElectionDatabaseDataSet25TableAdapters.tbl_SKcandidateTableAdapter tbl_SKcandidateTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partylistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesDataGridViewTextBoxColumn;
    }
}