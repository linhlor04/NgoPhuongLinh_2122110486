namespace NgoPhuongLinh_2122110486
{
    partial class PhepTinh
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
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(51, 63);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(28, 13);
            this.lbX.TabIndex = 1;
            this.lbX.Text = "Số x";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(51, 104);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(28, 13);
            this.lbY.TabIndex = 2;
            this.lbY.Text = "Số y";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(51, 142);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(44, 13);
            this.lbKQ.TabIndex = 5;
            this.lbKQ.Text = "Kết quả";
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(204, 291);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(114, 291);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(75, 23);
            this.btNhan.TabIndex = 8;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(285, 291);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(101, 101);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(227, 20);
            this.tbSoY.TabIndex = 10;
            this.tbSoY.TextChanged += new System.EventHandler(this.tbSoY_TextChanged);
            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(101, 60);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(227, 20);
            this.tbSoX.TabIndex = 11;
            this.tbSoX.TextChanged += new System.EventHandler(this.tbSoX_TextChanged);
            // 
            // tbKQ
            // 
            this.tbKQ.Location = new System.Drawing.Point(101, 139);
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.Size = new System.Drawing.Size(227, 20);
            this.tbKQ.TabIndex = 12;
            this.tbKQ.TextChanged += new System.EventHandler(this.tbKQ_TextChanged);
            // 
            // PhepTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 326);
            this.Controls.Add(this.tbKQ);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Name = "PhepTinh";
            this.Text = "PhepTinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbKQ;
    }
}