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
            this.btQLSV = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.btPheptinh = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btQLSV
            // 
            this.btQLSV.Location = new System.Drawing.Point(209, 70);
            this.btQLSV.Margin = new System.Windows.Forms.Padding(2);
            this.btQLSV.Name = "btQLSV";
            this.btQLSV.Size = new System.Drawing.Size(112, 47);
            this.btQLSV.TabIndex = 3;
            this.btQLSV.Text = "QuanLySinhVien";
            this.btQLSV.UseVisualStyleBackColor = true;
            this.btQLSV.Click += new System.EventHandler(this.btQLSV_Click);
            // 
            // btDN
            // 
            this.btDN.Location = new System.Drawing.Point(41, 70);
            this.btDN.Margin = new System.Windows.Forms.Padding(2);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(112, 47);
            this.btDN.TabIndex = 4;
            this.btDN.Text = "DangNhap";
            this.btDN.UseVisualStyleBackColor = true;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // btPheptinh
            // 
            this.btPheptinh.Location = new System.Drawing.Point(381, 70);
            this.btPheptinh.Margin = new System.Windows.Forms.Padding(2);
            this.btPheptinh.Name = "btPheptinh";
            this.btPheptinh.Size = new System.Drawing.Size(112, 47);
            this.btPheptinh.TabIndex = 5;
            this.btPheptinh.Text = "PhepTinh";
            this.btPheptinh.UseVisualStyleBackColor = true;
            this.btPheptinh.Click += new System.EventHandler(this.btPheptinh_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(209, 186);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(112, 47);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 292);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPheptinh);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.btQLSV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQLSV;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.Button btPheptinh;
        private System.Windows.Forms.Button btExit;
    }
}