using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgoPhuongLinh_2122110486
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //Kiểm tra Null
            if (tbUser.Text == "")
            {
                MessageBox.Show("Please enter your name!");
            }
            if (tbPass.Text == "")
            {
                MessageBox.Show("Please enter your password!");
            }
            else
            {
                MessageBox.Show("Logged in successfully");  
            }
            //Xóa thông tin log in
            tbUser.Clear();
            tbPass.Clear();

        }
        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void tbPass_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
