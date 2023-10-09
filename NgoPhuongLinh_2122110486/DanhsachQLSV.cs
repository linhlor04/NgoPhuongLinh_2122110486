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
                MessageBox.Show("Vui lòng nhập thông tin của b");
                return;
            }

            //kiểm tra có khác số hay không
            if (!IsNumeric(id))
            {
                MessageBox.Show("ID phải là số.");
                return;
            }
            //kiểm tra id đã tồn tại hay chưa
            if (usedIDs.Contains(id))
            {
                MessageBox.Show("ID đã tồn tại.");
                return;
            }

            //thêm id mới vào danh sách để kiểm tra
            usedIDs.Add(id);

            dataGridView1.Rows.Add(id, user, date, gender, faculty);
            MessageBox.Show("Thêm thành công");
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtUser.Clear();
            pbImg.Image = null;
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
            string id = txtID.Text;
            string user = txtUser.Text;
            DateTime date = dtpDate.Value;
            string faculty = cbbFaculty.Text;
            string gender = rbMale.Checked ? "Male" : "Female";

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(faculty))
            {
                MessageBox.Show("Vui lòng nhập thông tin của bạn!");
                return;
            }
            if (!IsNumeric(id))
            {
                MessageBox.Show("ID phải là số!.");
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

                    idFound = true;
                }
            }

            if (idFound)
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("ID cần chỉnh sửa không tồn tại.");
        }

        private void btDel_Click(object sender, EventArgs e)
        {

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
    }
}

