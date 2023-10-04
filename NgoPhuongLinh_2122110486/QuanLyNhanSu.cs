using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgoPhuongLinh_2122110486
{
    public partial class QuanLyNhanSu : Form
    {
        public QuanLyNhanSu()
        {
            InitializeComponent();
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

        private void pbImg_Click(object sender, EventArgs e)
        {

        }
    }
}
