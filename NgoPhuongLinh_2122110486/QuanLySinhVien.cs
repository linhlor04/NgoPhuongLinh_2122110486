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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string date = dtpDate.Text;
            string faculty = cbbFaculty.Text;
            string gender = rbMale.Checked? "Male" : "Female";

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(faculty))
            {
                MessageBox.Show("pls enter ur data");
            }    
            rtbStatus.Text = "UserName: " + user +
                            "\nDate: " + date +
                            "\nFaculty: " + faculty +
                            "\nGender: " + gender;

        }




        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
