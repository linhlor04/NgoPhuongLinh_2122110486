namespace NgoPhuongLinh_2122110486
{
    partial class DangNhap
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(64, 34);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(100, 23);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "UserName";
            // 
            // lbPass
            // 
            this.lbPass.Location = new System.Drawing.Point(64, 112);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(100, 23);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(230, 163);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(173, 43);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(170, 34);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(292, 26);
            this.tbUser.TabIndex = 5;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(170, 112);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(292, 26);
            this.tbPass.TabIndex = 6;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged_1);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 329);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Name = "DangNhap";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
    }
}