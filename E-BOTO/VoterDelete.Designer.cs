namespace E_BOTO
{
    partial class VoterDelete
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
            this.votersDatabaseDataSet7 = new E_BOTO.VotersDatabaseDataSet7();
            this.voterTableAdapter = new E_BOTO.VotersDatabaseDataSet7TableAdapters.VoterTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Add = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Vdeletetb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataMember = "Voter";
            this.voterBindingSource.DataSource = this.votersDatabaseDataSet7;
            // 
            // votersDatabaseDataSet7
            // 
            this.votersDatabaseDataSet7.DataSetName = "VotersDatabaseDataSet7";
            this.votersDatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterTableAdapter
            // 
            this.voterTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(464, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 46;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
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
            this.label1.Size = new System.Drawing.Size(179, 47);
            this.label1.TabIndex = 44;
            this.label1.Text = "DELETE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label2.TabIndex = 47;
            this.label2.Text = "Voter Information";
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
            this.Vaddress.Location = new System.Drawing.Point(28, 488);
            this.Vaddress.Name = "Vaddress";
            this.Vaddress.Size = new System.Drawing.Size(500, 36);
            this.Vaddress.TabIndex = 67;
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
            this.Vgender.Location = new System.Drawing.Point(407, 416);
            this.Vgender.Name = "Vgender";
            this.Vgender.Size = new System.Drawing.Size(121, 36);
            this.Vgender.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 65;
            this.label6.Text = "Precint:";
            // 
            // VfullnameTb
            // 
            this.VfullnameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VfullnameTb.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VfullnameTb.Location = new System.Drawing.Point(28, 343);
            this.VfullnameTb.Name = "VfullnameTb";
            this.VfullnameTb.Size = new System.Drawing.Size(500, 36);
            this.VfullnameTb.TabIndex = 58;
            // 
            // Vprecint
            // 
            this.Vprecint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vprecint.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vprecint.Location = new System.Drawing.Point(28, 561);
            this.Vprecint.Name = "Vprecint";
            this.Vprecint.Size = new System.Drawing.Size(500, 36);
            this.Vprecint.TabIndex = 64;
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
            this.label3.Location = new System.Drawing.Point(23, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Fullname: (Ex. Dela Cruz, Juan A.)";
            // 
            // VdateTimePicker1
            // 
            this.VdateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VdateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.VdateTimePicker1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VdateTimePicker1.Location = new System.Drawing.Point(28, 416);
            this.VdateTimePicker1.MaxDate = new System.DateTime(2005, 11, 29, 0, 0, 0, 0);
            this.VdateTimePicker1.MinDate = new System.DateTime(1993, 11, 29, 0, 0, 0, 0);
            this.VdateTimePicker1.Name = "VdateTimePicker1";
            this.VdateTimePicker1.Size = new System.Drawing.Size(375, 36);
            this.VdateTimePicker1.TabIndex = 63;
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
            this.label4.Location = new System.Drawing.Point(23, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 60;
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
            this.Vsex.Location = new System.Drawing.Point(402, 385);
            this.Vsex.Name = "Vsex";
            this.Vsex.Size = new System.Drawing.Size(60, 28);
            this.Vsex.TabIndex = 62;
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
            this.label5.Location = new System.Drawing.Point(23, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 61;
            this.label5.Text = "Address:";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackgroundImage = global::E_BOTO.Properties.Resources.bgbtn;
            this.Add.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = global::E_BOTO.Properties.Resources.icons8_table_properties_301;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(188, 653);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(170, 57);
            this.Add.TabIndex = 68;
            this.Add.Text = "     Update";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(197, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // Vdeletetb
            // 
            this.Vdeletetb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vdeletetb.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vdeletetb.Location = new System.Drawing.Point(28, 695);
            this.Vdeletetb.Name = "Vdeletetb";
            this.Vdeletetb.Size = new System.Drawing.Size(64, 36);
            this.Vdeletetb.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 70;
            this.label7.Text = "ID FILLER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // VoterDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(551, 807);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Vdeletetb);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoterDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterDelete";
            this.Load += new System.EventHandler(this.VoterDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VotersDatabaseDataSet7 votersDatabaseDataSet7;
        private System.Windows.Forms.BindingSource voterBindingSource;
        private VotersDatabaseDataSet7TableAdapters.VoterTableAdapter voterTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Vdeletetb;
        private System.Windows.Forms.Label label7;
    }
}