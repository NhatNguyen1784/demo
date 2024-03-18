namespace QLSV
{
    partial class UpdateStudentForm
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
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btUpImage = new System.Windows.Forms.Button();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.dtpkBDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtStdID = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbpicture = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.btFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.Red;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRemove.ForeColor = System.Drawing.Color.White;
            this.btRemove.Location = new System.Drawing.Point(646, 404);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(139, 36);
            this.btRemove.TabIndex = 25;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Blue;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(314, 404);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(139, 36);
            this.btEdit.TabIndex = 24;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            // 
            // btUpImage
            // 
            this.btUpImage.ForeColor = System.Drawing.Color.Black;
            this.btUpImage.Location = new System.Drawing.Point(800, 316);
            this.btUpImage.Name = "btUpImage";
            this.btUpImage.Size = new System.Drawing.Size(312, 23);
            this.btUpImage.TabIndex = 23;
            this.btUpImage.Text = "Upload Image";
            this.btUpImage.UseVisualStyleBackColor = true;
            // 
            // grbGender
            // 
            this.grbGender.Location = new System.Drawing.Point(239, 244);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(312, 51);
            this.grbGender.TabIndex = 21;
            this.grbGender.TabStop = false;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radFemale.ForeColor = System.Drawing.Color.White;
            this.radFemale.Location = new System.Drawing.Point(430, 260);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(98, 29);
            this.radFemale.TabIndex = 0;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radMale.ForeColor = System.Drawing.Color.White;
            this.radMale.Location = new System.Drawing.Point(254, 260);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(76, 29);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // dtpkBDate
            // 
            this.dtpkBDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkBDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkBDate.Location = new System.Drawing.Point(239, 198);
            this.dtpkBDate.Name = "dtpkBDate";
            this.dtpkBDate.Size = new System.Drawing.Size(312, 22);
            this.dtpkBDate.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddress.Location = new System.Drawing.Point(800, 31);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 89);
            this.txtAddress.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhone.Location = new System.Drawing.Point(239, 319);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(312, 30);
            this.txtPhone.TabIndex = 18;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLname.Location = new System.Drawing.Point(239, 144);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(312, 30);
            this.txtLname.TabIndex = 16;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFname.Location = new System.Drawing.Point(239, 90);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(312, 30);
            this.txtFname.TabIndex = 15;
            // 
            // txtStdID
            // 
            this.txtStdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStdID.Location = new System.Drawing.Point(239, 36);
            this.txtStdID.Name = "txtStdID";
            this.txtStdID.Size = new System.Drawing.Size(198, 30);
            this.txtStdID.TabIndex = 14;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGender.ForeColor = System.Drawing.Color.White;
            this.lbGender.Location = new System.Drawing.Point(42, 265);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(100, 29);
            this.lbGender.TabIndex = 12;
            this.lbGender.Text = "Gender";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBirthDate.ForeColor = System.Drawing.Color.White;
            this.lbBirthDate.Location = new System.Drawing.Point(42, 208);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(125, 29);
            this.lbBirthDate.TabIndex = 11;
            this.lbBirthDate.Text = "Birth date";
            // 
            // lbpicture
            // 
            this.lbpicture.AutoSize = true;
            this.lbpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbpicture.ForeColor = System.Drawing.Color.White;
            this.lbpicture.Location = new System.Drawing.Point(603, 188);
            this.lbpicture.Name = "lbpicture";
            this.lbpicture.Size = new System.Drawing.Size(95, 29);
            this.lbpicture.TabIndex = 10;
            this.lbpicture.Text = "Picture";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAddress.ForeColor = System.Drawing.Color.White;
            this.lbAddress.Location = new System.Drawing.Point(603, 36);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(109, 29);
            this.lbAddress.TabIndex = 9;
            this.lbAddress.Text = "Address";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(42, 322);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(88, 29);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "Phone";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLastName.ForeColor = System.Drawing.Color.White;
            this.lbLastName.Location = new System.Drawing.Point(42, 151);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(132, 29);
            this.lbLastName.TabIndex = 7;
            this.lbLastName.Text = "Last name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(42, 94);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(136, 29);
            this.lbFirstName.TabIndex = 13;
            this.lbFirstName.Text = "First name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(42, 37);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(134, 29);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "Student ID";
            // 
            // picAvt
            // 
            this.picAvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picAvt.Location = new System.Drawing.Point(800, 151);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(312, 159);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 20;
            this.picAvt.TabStop = false;
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFind.ForeColor = System.Drawing.Color.White;
            this.btFind.Location = new System.Drawing.Point(443, 36);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(108, 30);
            this.btFind.TabIndex = 24;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1156, 461);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btUpImage);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.picAvt);
            this.Controls.Add(this.dtpkBDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtStdID);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.lbpicture);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbID);
            this.Name = "UpdateStudentForm";
            this.Text = "UpdateStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btRemove;
        public System.Windows.Forms.Button btEdit;
        public System.Windows.Forms.Button btUpImage;
        public System.Windows.Forms.GroupBox grbGender;
        public System.Windows.Forms.RadioButton radFemale;
        public System.Windows.Forms.RadioButton radMale;
        public System.Windows.Forms.PictureBox picAvt;
        public System.Windows.Forms.DateTimePicker dtpkBDate;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtLname;
        public System.Windows.Forms.TextBox txtFname;
        public System.Windows.Forms.TextBox txtStdID;
        public System.Windows.Forms.Label lbGender;
        public System.Windows.Forms.Label lbBirthDate;
        public System.Windows.Forms.Label lbpicture;
        public System.Windows.Forms.Label lbAddress;
        public System.Windows.Forms.Label lbPhone;
        public System.Windows.Forms.Label lbLastName;
        public System.Windows.Forms.Label lbFirstName;
        public System.Windows.Forms.Label lbID;
        public System.Windows.Forms.Button btFind;
    }
}