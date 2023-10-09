namespace NgoPhuongLinh_2122110486
{
    partial class DanhsachQLSV
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
            this.cbbFaculty = new System.Windows.Forms.ComboBox();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btChoose = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbFaculty
            // 
            this.cbbFaculty.FormattingEnabled = true;
            this.cbbFaculty.Items.AddRange(new object[] {
            "Web developer",
            "Front-end developer",
            "Cyber security specialist",
            "QA/QC Engineer",
            "Bridge System Engineer",
            "App developer",
            "Game developer"});
            this.cbbFaculty.Location = new System.Drawing.Point(648, 37);
            this.cbbFaculty.Name = "cbbFaculty";
            this.cbbFaculty.Size = new System.Drawing.Size(317, 28);
            this.cbbFaculty.TabIndex = 21;
            // 
            // lbFaculty
            // 
            this.lbFaculty.AutoSize = true;
            this.lbFaculty.Location = new System.Drawing.Point(547, 40);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(60, 20);
            this.lbFaculty.TabIndex = 20;
            this.lbFaculty.Text = "Faculty";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(165, 148);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(317, 26);
            this.dtpDate.TabIndex = 19;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(165, 90);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(317, 26);
            this.txtUser.TabIndex = 18;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(165, 205);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(317, 97);
            this.gbGender.TabIndex = 17;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(184, 42);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(32, 42);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(53, 155);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 20);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "Date";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(53, 97);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(85, 20);
            this.lbUser.TabIndex = 15;
            this.lbUser.Text = "UserName";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnUser,
            this.ColumnDate,
            this.ColumnGender,
            this.ColumnFaculty,
            this.ColumnPhone,
            this.ColumnAddress,
            this.ColumnImg});
            this.dataGridView1.Location = new System.Drawing.Point(32, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 188);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(317, 26);
            this.txtID.TabIndex = 24;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(53, 43);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 20);
            this.lbId.TabIndex = 23;
            this.lbId.Text = "ID";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(495, 610);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(107, 50);
            this.btAdd.TabIndex = 25;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(620, 610);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(107, 50);
            this.btEdit.TabIndex = 26;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(1006, 610);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(107, 50);
            this.btExit.TabIndex = 27;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(751, 610);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(107, 50);
            this.btClear.TabIndex = 28;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(648, 193);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(317, 191);
            this.pbImg.TabIndex = 29;
            this.pbImg.TabStop = false;
            // 
            // btChoose
            // 
            this.btChoose.Location = new System.Drawing.Point(1019, 222);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(93, 80);
            this.btChoose.TabIndex = 30;
            this.btChoose.Text = "Choose";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(879, 610);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(107, 50);
            this.btDel.TabIndex = 31;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(547, 97);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(55, 20);
            this.lbPhone.TabIndex = 32;
            this.lbPhone.Text = "Phone";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(547, 158);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(68, 20);
            this.lbAddress.TabIndex = 34;
            this.lbAddress.Text = "Address";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(648, 90);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(317, 26);
            this.tbPhone.TabIndex = 35;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(648, 149);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(317, 26);
            this.tbAddress.TabIndex = 36;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnUser
            // 
            this.ColumnUser.HeaderText = "UserName";
            this.ColumnUser.MinimumWidth = 8;
            this.ColumnUser.Name = "ColumnUser";
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.MinimumWidth = 8;
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnGender
            // 
            this.ColumnGender.HeaderText = "Gender";
            this.ColumnGender.MinimumWidth = 8;
            this.ColumnGender.Name = "ColumnGender";
            // 
            // ColumnFaculty
            // 
            this.ColumnFaculty.HeaderText = "Faculty";
            this.ColumnFaculty.MinimumWidth = 8;
            this.ColumnFaculty.Name = "ColumnFaculty";
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Phone";
            this.ColumnPhone.MinimumWidth = 8;
            this.ColumnPhone.Name = "ColumnPhone";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.MinimumWidth = 8;
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnImg
            // 
            this.ColumnImg.HeaderText = "Image";
            this.ColumnImg.MinimumWidth = 8;
            this.ColumnImg.Name = "ColumnImg";
            // 
            // DanhsachQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 806);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbFaculty);
            this.Controls.Add(this.lbFaculty);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbUser);
            this.Name = "DanhsachQLSV";
            this.Text = "DanhsachQLSV";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFaculty;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImg;
    }
}