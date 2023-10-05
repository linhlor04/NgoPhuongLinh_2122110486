using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace NgoPhuongLinh_2122110486
//{
//    public partial class DanhsachQLSV : Form
//    {
//        public DanhsachQLSV()
//        {
//            InitializeComponent();
//        }

//        private void btAdd_Click(object sender, EventArgs e)
//        {
//            string id = txtID.Text;
//            string user = txtUser.Text;
//            DateTime date = dtpDate.Value;
//            string faculty = cbbFaculty.Text;
//            string gender = rbMale.Checked ? "Male" : "Female";
//            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(faculty))
//            {
//                MessageBox.Show("Please enter your data");
//            }
//            else
//            {
//                dataGridView1.Rows.Add(id, user, date, gender, faculty);
//                MessageBox.Show("Added successfully");
//                dataGridView1.Text = "ID: " + id +
//                                     "UserName: " + user +
//                                     "\nDate: " + date +
//                                     "\nGender: " + gender +
//                                     "\nFaculty: " + faculty;
//            }

//        }

//        private void txtID_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}

namespace NgoPhuongLinh_2122110486
{
    public partial class DanhsachQLSV : Form
    {
        //tạo danh sách chứa id đã nhập 
        private List<string> usedIDs = new List<string>();

        public DanhsachQLSV()
        {
            InitializeComponent();
        }
        private bool IsNumeric(string text)
        {
            return int.TryParse(text, out _);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string user = txtUser.Text;
            DateTime date = dtpDate.Value;
            string faculty = cbbFaculty.Text;
            string gender = rbMale.Checked ? "Male" : "Female";

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(faculty))
            {
                MessageBox.Show("Please enter your data");
                return;
            }

            //kiểm tra có khác số hay không
            if (!IsNumeric(id))
            {
                MessageBox.Show("ID must be a number.");
                return;
            }
            //kiểm tra id đã tồn tại hay chưa
            if (usedIDs.Contains(id))
            {
                MessageBox.Show("ID is already in use.");
                return;
            }

            //thêm id mới vào danh sách để kiểm tra
            usedIDs.Add(id);

            dataGridView1.Rows.Add(id, user, date, gender, faculty);
            MessageBox.Show("Added successfully");
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtUser.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImg.ImageLocation = dlg.FileName;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }
        private void btDel_Click(object sender, EventArgs e)
        {
                //xóa tất cả
                dataGridView1.Rows.Clear();
            }
            else if (result == DialogResult.No)
            {
                //Xóa hàng đã chọn
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }


    }
}

