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
    public partial class MayTinh : Form
    {

        decimal workingMemory = 0;
        string opr = " ";
        public MayTinh()
        {
            InitializeComponent();
        }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt3.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt6.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbOutput.Text += bt9.Text;
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            tbOutput.Text += btDoc.Text;
        }

  

        private void btEqual_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbOutput.Text);
            if (opr == "+")
                tbOutput.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                tbOutput.Text = (workingMemory * secondValue).ToString();
            if(opr == "/")
                tbOutput.Text = (workingMemory / secondValue).ToString();
            if(opr=="-")
                tbOutput.Text = (workingMemory - secondValue).ToString();
        }
        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbOutput.Text);
            tbOutput.Clear();
        }

        private void btTimes_Click(object sender, EventArgs e)
        { 
            opr = btTimes.Text;
            workingMemory = decimal.Parse(tbOutput.Text);
            tbOutput.Clear();
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            opr = btMinus.Text;
            workingMemory = decimal.Parse(tbOutput.Text);
            tbOutput.Clear();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            opr = btDiv.Text;
            workingMemory = decimal.Parse(tbOutput.Text);
            tbOutput.Clear();
        }

        private void btAC_Click(object sender, EventArgs e)
        {
            tbOutput.Clear();
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length > 0)
            {
                tbOutput.Text = tbOutput.Text.Remove(tbOutput.Text.Length - 1);
            }
        }
    }
}
