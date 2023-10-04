namespace NgoPhuongLinh_2122110486
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btDN = new System.Windows.Forms.Button();
            this.btPheptinh = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btQLSV = new System.Windows.Forms.Button();
            this.btMayTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btDN
            // 
            this.btDN.Location = new System.Drawing.Point(62, 108);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(168, 72);
            this.btDN.TabIndex = 4;
            this.btDN.Text = "DangNhap";
            this.btDN.UseVisualStyleBackColor = true;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // btPheptinh
            // 
            this.btPheptinh.Location = new System.Drawing.Point(572, 108);
            this.btPheptinh.Name = "btPheptinh";
            this.btPheptinh.Size = new System.Drawing.Size(168, 72);
            this.btPheptinh.TabIndex = 5;
            this.btPheptinh.Text = "PhepTinh";
            this.btPheptinh.UseVisualStyleBackColor = true;
            this.btPheptinh.Click += new System.EventHandler(this.btPheptinh_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(313, 365);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(168, 72);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btQLSV
            // 
            this.btQLSV.Location = new System.Drawing.Point(323, 108);
            this.btQLSV.Name = "btQLSV";
            this.btQLSV.Size = new System.Drawing.Size(168, 72);
            this.btQLSV.TabIndex = 7;
            this.btQLSV.Text = "QuanLySinhVien";
            this.btQLSV.UseVisualStyleBackColor = true;
            this.btQLSV.Click += new System.EventHandler(this.btQLSV_Click);
            // 
            // btMayTinh
            // 
            this.btMayTinh.Location = new System.Drawing.Point(62, 215);
            this.btMayTinh.Name = "btMayTinh";
            this.btMayTinh.Size = new System.Drawing.Size(168, 72);
            this.btMayTinh.TabIndex = 8;
            this.btMayTinh.Text = "MayTinh";
            this.btMayTinh.UseVisualStyleBackColor = true;
            this.btMayTinh.Click += new System.EventHandler(this.btMayTinh_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 449);
            this.Controls.Add(this.btMayTinh);
            this.Controls.Add(this.btQLSV);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPheptinh);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.Button btPheptinh;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btQLSV;
        private System.Windows.Forms.Button btMayTinh;
    }
}