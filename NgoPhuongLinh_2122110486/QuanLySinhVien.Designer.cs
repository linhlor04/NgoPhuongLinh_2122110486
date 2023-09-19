namespace NgoPhuongLinh_2122110486
{
    partial class QuanLySinhVien
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFe = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.richtbStatus = new System.Windows.Forms.RichTextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(165, 80);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(165, 154);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(271, 26);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(33, 85);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(123, 31);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "UserName";
            this.lbUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(70, 154);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(72, 31);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date";
            this.lbDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFe);
            this.gbGender.Controls.Add(this.rbMan);
            this.gbGender.Location = new System.Drawing.Point(165, 229);
            this.gbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGender.Size = new System.Drawing.Size(273, 88);
            this.gbGender.TabIndex = 8;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            this.gbGender.Enter += new System.EventHandler(this.gbGender_Enter);
            // 
            // rbFe
            // 
            this.rbFe.AutoSize = true;
            this.rbFe.Location = new System.Drawing.Point(147, 29);
            this.rbFe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFe.Name = "rbFe";
            this.rbFe.Size = new System.Drawing.Size(87, 24);
            this.rbFe.TabIndex = 1;
            this.rbFe.TabStop = true;
            this.rbFe.Text = "Female";
            this.rbFe.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(9, 29);
            this.rbMan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(68, 24);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Male";
            this.rbMan.UseVisualStyleBackColor = true;
            this.rbMan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbFaculty
            // 
            this.lbFaculty.Location = new System.Drawing.Point(57, 351);
            this.lbFaculty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(80, 38);
            this.lbFaculty.TabIndex = 9;
            this.lbFaculty.Text = "Faculty";
            this.lbFaculty.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbFaculty
            // 
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "Information Technology",
            "Accounting Major"});
            this.cbFaculty.Location = new System.Drawing.Point(165, 351);
            this.cbFaculty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(271, 28);
            this.cbFaculty.TabIndex = 10;
            this.cbFaculty.Text = " ";
            this.cbFaculty.SelectedIndexChanged += new System.EventHandler(this.cbFaculty_SelectedIndexChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(62, 428);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(80, 38);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status";
            // 
            // richtbStatus
            // 
            this.richtbStatus.Location = new System.Drawing.Point(165, 428);
            this.richtbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richtbStatus.Name = "richtbStatus";
            this.richtbStatus.ReadOnly = true;
            this.richtbStatus.Size = new System.Drawing.Size(271, 233);
            this.richtbStatus.TabIndex = 12;
            this.richtbStatus.Text = "";
            this.richtbStatus.TextChanged += new System.EventHandler(this.richtbStatus_TextChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(165, 702);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(112, 35);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(324, 702);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(112, 35);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 878);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.richtbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.lbFaculty);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbFe;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.RichTextBox richtbStatus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
    }
}

