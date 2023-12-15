namespace E_BOTO
{
    partial class CandidateCreate
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
            this.tblSKcandidatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet6 = new E_BOTO.ElectionDatabaseDataSet6();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet = new E_BOTO.ElectionDatabaseDataSet();
            this.candidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter();
            this.electionDatabaseDataSet3 = new E_BOTO.ElectionDatabaseDataSet3();
            this.tblSKcandidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SKcandidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSet3TableAdapters.tbl_SKcandidatesTableAdapter();
            this.tbl_SKcandidatesTableAdapter1 = new E_BOTO.ElectionDatabaseDataSet6TableAdapters.tbl_SKcandidatesTableAdapter();
            this.fullnameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.partylisttb = new System.Windows.Forms.ComboBox();
            this.positiontb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSKcandidatesBindingSource1
            // 
            this.tblSKcandidatesBindingSource1.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource1.DataSource = this.electionDatabaseDataSet6;
            // 
            // electionDatabaseDataSet6
            // 
            this.electionDatabaseDataSet6.DataSetName = "ElectionDatabaseDataSet6";
            this.electionDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // electionDatabaseDataSet3
            // 
            this.electionDatabaseDataSet3.DataSetName = "ElectionDatabaseDataSet3";
            this.electionDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSKcandidatesBindingSource
            // 
            this.tblSKcandidatesBindingSource.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource.DataSource = this.electionDatabaseDataSet3;
            // 
            // tbl_SKcandidatesTableAdapter
            // 
            this.tbl_SKcandidatesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SKcandidatesTableAdapter1
            // 
            this.tbl_SKcandidatesTableAdapter1.ClearBeforeFill = true;
            // 
            // fullnameTb
            // 
            this.fullnameTb.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTb.Location = new System.Drawing.Point(30, 476);
            this.fullnameTb.Name = "fullnameTb";
            this.fullnameTb.Size = new System.Drawing.Size(500, 36);
            this.fullnameTb.TabIndex = 22;
            this.fullnameTb.Text = " ";
            this.fullnameTb.TextChanged += new System.EventHandler(this.fullnameTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fullname: (Ex. Dela Cruz, Juan A.)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Position:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(340, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Party-List:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // partylisttb
            // 
            this.partylisttb.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partylisttb.FormattingEnabled = true;
            this.partylisttb.Items.AddRange(new object[] {
            "Party List A",
            "Party List B",
            "Party List C"});
            this.partylisttb.Location = new System.Drawing.Point(345, 549);
            this.partylisttb.Name = "partylisttb";
            this.partylisttb.Size = new System.Drawing.Size(185, 36);
            this.partylisttb.TabIndex = 32;
            // 
            // positiontb
            // 
            this.positiontb.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiontb.FormattingEnabled = true;
            this.positiontb.Items.AddRange(new object[] {
            "Chairman/Chairwoman",
            "Kagawad"});
            this.positiontb.Location = new System.Drawing.Point(30, 549);
            this.positiontb.Name = "positiontb";
            this.positiontb.Size = new System.Drawing.Size(309, 36);
            this.positiontb.TabIndex = 33;
            this.positiontb.SelectedIndexChanged += new System.EventHandler(this.positiontb_SelectedIndexChanged);
            this.positiontb.DropDownStyleChanged += new System.EventHandler(this.positiontb_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(464, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 49;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 47);
            this.label2.TabIndex = 48;
            this.label2.Text = "Create Candidate";
            // 
            // uploadC
            // 
            this.uploadC.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadC.ForeColor = System.Drawing.Color.Black;
            this.uploadC.Image = global::E_BOTO.Properties.Resources.icons8_add_new_30;
            this.uploadC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadC.Location = new System.Drawing.Point(327, 306);
            this.uploadC.Name = "uploadC";
            this.uploadC.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.uploadC.Size = new System.Drawing.Size(149, 55);
            this.uploadC.TabIndex = 51;
            this.uploadC.Text = "     Upload";
            this.uploadC.UseVisualStyleBackColor = true;
            this.uploadC.Click += new System.EventHandler(this.uploadC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(197, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Image = global::E_BOTO.Properties.Resources.icons8_add_new_30;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(188, 653);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(170, 57);
            this.Add.TabIndex = 31;
            this.Add.Text = "     Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // CandidateCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(551, 807);
            this.Controls.Add(this.uploadC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.positiontb);
            this.Controls.Add(this.partylisttb);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.fullnameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateCreate";
            this.Load += new System.EventHandler(this.CandidateCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ElectionDatabaseDataSet electionDatabaseDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private ElectionDatabaseDataSet3 electionDatabaseDataSet3;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource;
        private ElectionDatabaseDataSet3TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter;
        private ElectionDatabaseDataSet6 electionDatabaseDataSet6;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource1;
        private ElectionDatabaseDataSet6TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter1;
        private System.Windows.Forms.TextBox fullnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox partylisttb;
        private System.Windows.Forms.ComboBox positiontb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uploadC;
    }
}