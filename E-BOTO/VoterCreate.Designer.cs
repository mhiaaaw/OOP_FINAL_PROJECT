namespace E_BOTO
{
    partial class VoterCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterCreate));
            this.voterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet6 = new E_BOTO.VotersDatabaseDataSet6();
            this.votersDatabaseDataSet = new E_BOTO.VotersDatabaseDataSet();
            this.votersDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VoterTableAdapter = new E_BOTO.VotersDatabaseDataSetTableAdapters.tbl_VoterTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VfullnameTb = new System.Windows.Forms.TextBox();
            this.Vaddress = new System.Windows.Forms.ComboBox();
            this.Vgender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Vsex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblVoterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet1 = new E_BOTO.VotersDatabaseDataSet1();
            this.voterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voterTableAdapter = new E_BOTO.VotersDatabaseDataSet1TableAdapters.VoterTableAdapter();
            this.tblVoterBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet4 = new E_BOTO.VotersDatabaseDataSet4();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter = new E_BOTO.VotersDatabaseDataSet4TableAdapters.VotersTableAdapter();
            this.voterTableAdapter1 = new E_BOTO.VotersDatabaseDataSet6TableAdapters.VoterTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.Vprecint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoterBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // voterBindingSource1
            // 
            this.voterBindingSource1.DataMember = "Voter";
            this.voterBindingSource1.DataSource = this.votersDatabaseDataSet6;
            // 
            // votersDatabaseDataSet6
            // 
            this.votersDatabaseDataSet6.DataSetName = "VotersDatabaseDataSet6";
            this.votersDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersDatabaseDataSet
            // 
            this.votersDatabaseDataSet.DataSetName = "VotersDatabaseDataSet";
            this.votersDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersDatabaseDataSetBindingSource
            // 
            this.votersDatabaseDataSetBindingSource.DataSource = this.votersDatabaseDataSet;
            this.votersDatabaseDataSetBindingSource.Position = 0;
            // 
            // tbl_VoterTableAdapter
            // 
            this.tbl_VoterTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Birthday:";
            // 
            // VfullnameTb
            // 
            this.VfullnameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VfullnameTb.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VfullnameTb.Location = new System.Drawing.Point(27, 399);
            this.VfullnameTb.Name = "VfullnameTb";
            this.VfullnameTb.Size = new System.Drawing.Size(500, 36);
            this.VfullnameTb.TabIndex = 22;
            this.VfullnameTb.TextChanged += new System.EventHandler(this.fullnameTb_TextChanged);
            this.VfullnameTb.Enter += new System.EventHandler(this.VfullnameTb_Enter);
            this.VfullnameTb.Leave += new System.EventHandler(this.VfullnameTb_Leave);
            // 
            // Vaddress
            // 
            this.Vaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vaddress.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaddress.FormattingEnabled = true;
            this.Vaddress.Items.AddRange(new object[] {
            "Padrigal, Karuhatan, Valenzuela",
            "BSOP, Karuhatan, Valenzuela",
            "Cantillon, Karuhatan, Valenzuela",
            "Pablo, Karuhatan, Valenzuela",
            "De Castro, Karuhatan, Valenzuela"});
            this.Vaddress.Location = new System.Drawing.Point(27, 544);
            this.Vaddress.Name = "Vaddress";
            this.Vaddress.Size = new System.Drawing.Size(500, 36);
            this.Vaddress.TabIndex = 40;
            this.Vaddress.SelectedIndexChanged += new System.EventHandler(this.Vaddress_SelectedIndexChanged);
            // 
            // Vgender
            // 
            this.Vgender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vgender.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vgender.FormattingEnabled = true;
            this.Vgender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.Vgender.Location = new System.Drawing.Point(406, 472);
            this.Vgender.Name = "Vgender";
            this.Vgender.Size = new System.Drawing.Size(121, 36);
            this.Vgender.TabIndex = 39;
            this.Vgender.SelectedIndexChanged += new System.EventHandler(this.Vage_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Precint:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // VdateTimePicker1
            // 
            this.VdateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VdateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.VdateTimePicker1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VdateTimePicker1.Location = new System.Drawing.Point(27, 472);
            this.VdateTimePicker1.MaxDate = new System.DateTime(2005, 11, 29, 0, 0, 0, 0);
            this.VdateTimePicker1.MinDate = new System.DateTime(1993, 11, 29, 0, 0, 0, 0);
            this.VdateTimePicker1.Name = "VdateTimePicker1";
            this.VdateTimePicker1.Size = new System.Drawing.Size(375, 36);
            this.VdateTimePicker1.TabIndex = 36;
            this.VdateTimePicker1.Value = new System.DateTime(2005, 11, 29, 0, 0, 0, 0);
            this.VdateTimePicker1.ValueChanged += new System.EventHandler(this.VdateTimePicker1_ValueChanged);
            // 
            // Vsex
            // 
            this.Vsex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vsex.AutoSize = true;
            this.Vsex.BackColor = System.Drawing.Color.Transparent;
            this.Vsex.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vsex.ForeColor = System.Drawing.Color.White;
            this.Vsex.Location = new System.Drawing.Point(401, 441);
            this.Vsex.Name = "Vsex";
            this.Vsex.Size = new System.Drawing.Size(60, 28);
            this.Vsex.TabIndex = 34;
            this.Vsex.Text = "Sex:";
            this.Vsex.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fullname: (Ex. Dela Cruz, Juan A.)";
            // 
            // tblVoterBindingSource1
            // 
            this.tblVoterBindingSource1.DataMember = "tbl_Voter";
            this.tblVoterBindingSource1.DataSource = this.votersDatabaseDataSetBindingSource;
            // 
            // votersDatabaseDataSet1
            // 
            this.votersDatabaseDataSet1.DataSetName = "VotersDatabaseDataSet1";
            this.votersDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataMember = "Voter";
            this.voterBindingSource.DataSource = this.votersDatabaseDataSet1;
            // 
            // voterTableAdapter
            // 
            this.voterTableAdapter.ClearBeforeFill = true;
            // 
            // tblVoterBindingSource3
            // 
            this.tblVoterBindingSource3.DataMember = "tbl_Voter";
            this.tblVoterBindingSource3.DataSource = this.votersDatabaseDataSetBindingSource;
            // 
            // votersDatabaseDataSet4
            // 
            this.votersDatabaseDataSet4.DataSetName = "VotersDatabaseDataSet4";
            this.votersDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource
            // 
            this.votersBindingSource.DataMember = "Voters";
            this.votersBindingSource.DataSource = this.votersDatabaseDataSet4;
            // 
            // votersTableAdapter
            // 
            this.votersTableAdapter.ClearBeforeFill = true;
            // 
            // voterTableAdapter1
            // 
            this.voterTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(464, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 43;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Vprecint
            // 
            this.Vprecint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vprecint.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vprecint.Location = new System.Drawing.Point(27, 321);
            this.Vprecint.Name = "Vprecint";
            this.Vprecint.Size = new System.Drawing.Size(121, 36);
            this.Vprecint.TabIndex = 37;
            this.Vprecint.Text = " ";
            this.Vprecint.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 37);
            this.label2.TabIndex = 49;
            this.label2.Text = "Voter Information";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 47);
            this.label1.TabIndex = 48;
            this.label1.Text = "CREATE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(197, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackgroundImage = global::E_BOTO.Properties.Resources.bgbtn;
            this.Add.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = global::E_BOTO.Properties.Resources.icons8_insert_table_303;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(188, 653);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(170, 57);
            this.Add.TabIndex = 31;
            this.Add.Text = "     Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // VoterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(551, 807);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Vaddress);
            this.Controls.Add(this.Vgender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VfullnameTb);
            this.Controls.Add(this.Vprecint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VdateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Vsex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoterCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.VoterCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoterBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource votersDatabaseDataSetBindingSource;
        private VotersDatabaseDataSet votersDatabaseDataSet;
        private VotersDatabaseDataSetTableAdapters.tbl_VoterTableAdapter tbl_VoterTableAdapter;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VfullnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Vsex;
        private System.Windows.Forms.DateTimePicker VdateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource tblVoterBindingSource1;
        private VotersDatabaseDataSet1 votersDatabaseDataSet1;
        private System.Windows.Forms.BindingSource voterBindingSource;
        private VotersDatabaseDataSet1TableAdapters.VoterTableAdapter voterTableAdapter;
        private System.Windows.Forms.BindingSource tblVoterBindingSource3;
        private VotersDatabaseDataSet4 votersDatabaseDataSet4;
        private System.Windows.Forms.BindingSource votersBindingSource;
        private VotersDatabaseDataSet4TableAdapters.VotersTableAdapter votersTableAdapter;
        private VotersDatabaseDataSet6 votersDatabaseDataSet6;
        private System.Windows.Forms.BindingSource voterBindingSource1;
        private VotersDatabaseDataSet6TableAdapters.VoterTableAdapter voterTableAdapter1;
        private System.Windows.Forms.ComboBox Vgender;
        private System.Windows.Forms.ComboBox Vaddress;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Vprecint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}