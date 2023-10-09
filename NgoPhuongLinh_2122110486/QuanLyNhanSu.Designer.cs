namespace NgoPhuongLinh_2122110486
{
    partial class QuanLyNhanSu
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btChoose = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(190, 208);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(256, 230);
            this.pbImg.TabIndex = 4;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click);
            // 
            // btChoose
            // 
            this.btChoose.Location = new System.Drawing.Point(498, 208);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(132, 76);
            this.btChoose.TabIndex = 5;
            this.btChoose.Text = "Choose";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(498, 321);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(132, 76);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 26);
            this.textBox2.TabIndex = 3;
            // 
            // QuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyNhanSu";
            this.Text = "QuanLyNhanSu";
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.TextBox textBox2;
    }
}