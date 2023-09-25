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
    public partial class PhepTinh : Form
    {
        public PhepTinh()
        {
            InitializeComponent();
        }

        

        private void tbSoX_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoY_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbKQ_TextChanged(object sender, EventArgs e)
        {

        }
        private void btCong_Click(object sender, EventArgs e)
        {
            if (tbSoX.Text == "" && tbSoY.Text == "")
            {
                MessageBox.Show("Pls enter ur number!");
            }
            else
            {
                double x = Convert.ToDouble(tbSoX.Text);
                double y = Convert.ToDouble(tbSoY.Text);
                double kq = x + y;
                tbKQ.Text = kq.ToString();
            }    

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            if (tbSoX.Text == "" && tbSoY.Text == "")
            {
                MessageBox.Show("Pls enter ur number!");
            }
            else
            {
                double x = Convert.ToDouble(tbSoX.Text);
                double y = Convert.ToDouble(tbSoY.Text);
                double kq = x * y;
                tbKQ.Text = kq.ToString();
            }

        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
