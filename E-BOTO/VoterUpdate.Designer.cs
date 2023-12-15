namespace E_BOTO
{
    partial class VoterUpdate
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
            this.voterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet6 = new E_BOTO.VotersDatabaseDataSet6();
            this.voterTableAdapter = new E_BOTO.VotersDatabaseDataSet6TableAdapters.VoterTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.Vaddress = new System.Windows.Forms.ComboBox();
            this.Vgender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VfullnameTb = new System.Windows.Forms.TextBox();
            this.Vprecint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Vsex = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voterBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet18 = new E_BOTO.ElectionDatabaseDataSet18();
            this.voterBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet9 = new E_BOTO.VotersDatabaseDataSet9();
            this.voterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voterTableAdapter1 = new E_BOTO.VotersDatabaseDataSet9TableAdapters.VoterTableAdapter();
            this.voterTableAdapter2 = new E_BOTO.ElectionDatabaseDataSet18TableAdapters.VoterTableAdapter();
            this.electionDatabaseDataSet20 = new E_BOTO.ElectionDatabaseDataSet20();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter = new E_BOTO.ElectionDatabaseDataSet20TableAdapters.VotersTableAdapter();
            this.electionDatabaseDataSet22 = new E_BOTO.ElectionDatabaseDataSet22();
            this.voterssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voterssTableAdapter = new E_BOTO.ElectionDatabaseDataSet22TableAdapters.VoterssTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataMember = "Voter";
            this.voterBindingSource.DataSource = this.votersDatabaseDataSet6BindingSource;
            // 
            // votersDatabaseDataSet6BindingSource
            // 
            this.votersDatabaseDataSet6BindingSource.DataSource = this.votersDatabaseDataSet6;
            this.votersDatabaseDataSet6BindingSource.Position = 0;
            // 
            // votersDatabaseDataSet6
            // 
            this.votersDatabaseDataSet6.DataSetName = "VotersDatabaseDataSet6";
            this.votersDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterTableAdapter
            // 
            this.voterTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1194, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 46;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Vaddress.Location = new System.Drawing.Point(41, 558);
            this.Vaddress.Name = "Vaddress";
            this.Vaddress.Size = new System.Drawing.Size(500, 36);
            this.Vaddress.TabIndex = 81;
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
            this.Vgender.Location = new System.Drawing.Point(420, 486);
            this.Vgender.Name = "Vgender";
            this.Vgender.Size = new System.Drawing.Size(121, 36);
            this.Vgender.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 79;
            this.label6.Text = "Precint:";
            // 
            // VfullnameTb
            // 
            this.VfullnameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VfullnameTb.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VfullnameTb.Location = new System.Drawing.Point(41, 413);
            this.VfullnameTb.Name = "VfullnameTb";
            this.VfullnameTb.Size = new System.Drawing.Size(500, 36);
            this.VfullnameTb.TabIndex = 72;
            // 
            // Vprecint
            // 
            this.Vprecint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vprecint.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vprecint.Location = new System.Drawing.Point(41, 342);
            this.Vprecint.Name = "Vprecint";
            this.Vprecint.Size = new System.Drawing.Size(121, 36);
            this.Vprecint.TabIndex = 78;
            this.Vprecint.Text = " ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 28);
            this.label3.TabIndex = 73;
            this.label3.Text = "Fullname: (Ex. Dela Cruz, Juan A.)";
            // 
            // VdateTimePicker1
            // 
            this.VdateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VdateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.VdateTimePicker1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VdateTimePicker1.Location = new System.Drawing.Point(41, 486);
            this.VdateTimePicker1.MaxDate = new System.DateTime(2005, 11, 29, 0, 0, 0, 0);
            this.VdateTimePicker1.MinDate = new System.DateTime(1993, 11, 29, 0, 0, 0, 0);
            this.VdateTimePicker1.Name = "VdateTimePicker1";
            this.VdateTimePicker1.Size = new System.Drawing.Size(375, 36);
            this.VdateTimePicker1.TabIndex = 77;
            this.VdateTimePicker1.Value = new System.DateTime(2005, 11, 29, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 74;
            this.label4.Text = "Birthday:";
            // 
            // Vsex
            // 
            this.Vsex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vsex.AutoSize = true;
            this.Vsex.BackColor = System.Drawing.Color.Transparent;
            this.Vsex.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vsex.ForeColor = System.Drawing.Color.White;
            this.Vsex.Location = new System.Drawing.Point(415, 455);
            this.Vsex.Name = "Vsex";
            this.Vsex.Size = new System.Drawing.Size(60, 28);
            this.Vsex.TabIndex = 76;
            this.Vsex.Text = "Sex:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 75;
            this.label5.Text = "Address:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 37);
            this.label2.TabIndex = 71;
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
            this.label1.Location = new System.Drawing.Point(200, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 47);
            this.label1.TabIndex = 69;
            this.label1.Text = "UPDATE";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackgroundImage = global::E_BOTO.Properties.Resources.bgbtn;
            this.Add.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = global::E_BOTO.Properties.Resources.icons8_table_properties_301;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(202, 671);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(170, 57);
            this.Add.TabIndex = 82;
            this.Add.Text = "     Update";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(208, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.precintDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voterssBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(581, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(668, 497);
            this.dataGridView1.TabIndex = 83;
            // 
            // voterBindingSource3
            // 
            this.voterBindingSource3.DataMember = "Voter";
            this.voterBindingSource3.DataSource = this.electionDatabaseDataSet18;
            // 
            // electionDatabaseDataSet18
            // 
            this.electionDatabaseDataSet18.DataSetName = "ElectionDatabaseDataSet18";
            this.electionDatabaseDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterBindingSource2
            // 
            this.voterBindingSource2.DataMember = "Voter";
            this.voterBindingSource2.DataSource = this.votersDatabaseDataSet9;
            // 
            // votersDatabaseDataSet9
            // 
            this.votersDatabaseDataSet9.DataSetName = "VotersDatabaseDataSet9";
            this.votersDatabaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterBindingSource1
            // 
            this.voterBindingSource1.DataMember = "Voter";
            this.voterBindingSource1.DataSource = this.votersDatabaseDataSet6BindingSource;
            // 
            // voterTableAdapter1
            // 
            this.voterTableAdapter1.ClearBeforeFill = true;
            // 
            // voterTableAdapter2
            // 
            this.voterTableAdapter2.ClearBeforeFill = true;
            // 
            // electionDatabaseDataSet20
            // 
            this.electionDatabaseDataSet20.DataSetName = "ElectionDatabaseDataSet20";
            this.electionDatabaseDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource
            // 
            this.votersBindingSource.DataMember = "Voters";
            this.votersBindingSource.DataSource = this.electionDatabaseDataSet20;
            // 
            // votersTableAdapter
            // 
            this.votersTableAdapter.ClearBeforeFill = true;
            // 
            // electionDatabaseDataSet22
            // 
            this.electionDatabaseDataSet22.DataSetName = "ElectionDatabaseDataSet22";
            this.electionDatabaseDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterssBindingSource
            // 
            this.voterssBindingSource.DataMember = "Voterss";
            this.voterssBindingSource.DataSource = this.electionDatabaseDataSet22;
            // 
            // voterssTableAdapter
            // 
            this.voterssTableAdapter.ClearBeforeFill = true;
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
            // precintDataGridViewTextBoxColumn
            // 
            this.precintDataGridViewTextBoxColumn.DataPropertyName = "Precint";
            this.precintDataGridViewTextBoxColumn.HeaderText = "Precint";
            this.precintDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precintDataGridViewTextBoxColumn.Name = "precintDataGridViewTextBoxColumn";
            this.precintDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // VoterUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1281, 807);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoterUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterUpdate";
            this.Load += new System.EventHandler(this.VoterUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterssBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource votersDatabaseDataSet6BindingSource;
        private VotersDatabaseDataSet6 votersDatabaseDataSet6;
        private System.Windows.Forms.BindingSource voterBindingSource;
        private VotersDatabaseDataSet6TableAdapters.VoterTableAdapter voterTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox Vaddress;
        private System.Windows.Forms.ComboBox Vgender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VfullnameTb;
        private System.Windows.Forms.TextBox Vprecint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker VdateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Vsex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource voterBindingSource1;
        private VotersDatabaseDataSet9 votersDatabaseDataSet9;
        private System.Windows.Forms.BindingSource voterBindingSource2;
        private VotersDatabaseDataSet9TableAdapters.VoterTableAdapter voterTableAdapter1;
        private ElectionDatabaseDataSet18 electionDatabaseDataSet18;
        private System.Windows.Forms.BindingSource voterBindingSource3;
        private ElectionDatabaseDataSet18TableAdapters.VoterTableAdapter voterTableAdapter2;
        private ElectionDatabaseDataSet20 electionDatabaseDataSet20;
        private System.Windows.Forms.BindingSource votersBindingSource;
        private ElectionDatabaseDataSet20TableAdapters.VotersTableAdapter votersTableAdapter;
        private ElectionDatabaseDataSet22 electionDatabaseDataSet22;
        private System.Windows.Forms.BindingSource voterssBindingSource;
        private ElectionDatabaseDataSet22TableAdapters.VoterssTableAdapter voterssTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}