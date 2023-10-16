using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NgoPhuongLinh_2122110486
{
    public partial class DanhsachQLSV : Form
    {
        //tạo danh sách chứa id đã nhập 
        private List<string> usedIDs = new List<string>();
        private string s = null;

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
            string phone = tbPhone.Text;
            string address = tbAddress.Text;
           
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(faculty) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter your data!");
                return;
            }

            //kiểm tra có khác số hay không 
            if (!IsNumeric(id))
            {
                MessageBox.Show("Please enter ID as number");
                return;
            }
            if (!IsNumeric(phone))
            {
                MessageBox.Show("Please enter the phonenumber as the number!");
                return;
            }    
            //kiểm tra id đã tồn tại hay chưa
            if (usedIDs.Contains(id))
            {
                MessageBox.Show("ID already exists.");
                return;
            }

            //thêm id mới vào danh sách để kiểm tra
            usedIDs.Add(id);

            dataGridView1.Rows.Add(id, user, date, gender, faculty, phone, address,s);
            MessageBox.Show("Added successfully");
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtUser.Clear();
            pbImg.Image = null;
            tbAddress.Clear();
            tbPhone.Clear();
            cbbFaculty.SelectedIndex = -1;
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
            dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImg.ImageLocation = dlg.FileName;
                s = dlg.FileName;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string user = txtUser.Text;
            DateTime date = dtpDate.Value;
            string faculty = cbbFaculty.Text;
            string gender = rbMale.Checked ? "Male" : "Female";

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(faculty))
            {
                MessageBox.Show("There is no data to edit!");
                return;
            }
            if (!IsNumeric(id))
            {
                MessageBox.Show("Please enter ID as number!.");
                return;
            }

            bool idFound = false;
            // tìm id trùng với idFound cần edit thông tin
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ColumnID"].Value != null && row.Cells["ColumnID"].Value.ToString() == id)
                {
                    //edit lại thông tin của id đó
                    row.Cells["ColumnUser"].Value = user;
                    row.Cells["ColumnDate"].Value = date;
                    row.Cells["ColumnGender"].Value = gender;
                    row.Cells["ColumnFaculty"].Value = faculty;
                    row.Cells["ColumnPhone"].Value = tbPhone.Text;
                    row.Cells["ColumnAddress"].Value = tbAddress.Text;
                    row.Cells["ColumnImg"].Value = s;
                    idFound = true;
                }
            }

                MessageBox.Show("Update successful");
            else
                MessageBox.Show("ID cần chỉnh sửa không tồn tại.");
        }

        private void btDel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to delete");
                return;
            }
            //Xóa hàng đã chọn
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    //lấy id từ hàng đã chọn
                    string idToDelete = row.Cells["ColumnID"].Value.ToString();
                    dataGridView1.Rows.Remove(row);
                    //xóa id đó 
                    usedIDs.Remove(idToDelete);
                }
            }
            pbImg.Image = null;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtUser.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                string gender = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                if (gender == "Male")
                {
                    rbMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rbFemale.Checked = true;
                }
                else
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                }
            }
        }
    }
}

