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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btDN_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }


        private void label1_Click(object sender, EventArgs e)  //Menu
        {

        }

        private void btPheptinh_Click(object sender, EventArgs e)
        {
            PhepTinh phepTinh = new PhepTinh();
            phepTinh.ShowDialog();
        }
        private void btQLSV_Click(object sender, EventArgs e)
        {
            QuanLySinhVien qlsv = new QuanLySinhVien();
            qlsv.ShowDialog();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMayTinh_Click(object sender, EventArgs e)
        {
            MayTinh mt = new MayTinh();
            mt.ShowDialog();
        }
    }
}
