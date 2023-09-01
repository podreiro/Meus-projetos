using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logP_trabai
{
    public partial class exercicio4 : Form
    {
        public exercicio4()
        {
            InitializeComponent();
        }
        double total;
        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (chk10.Checked)
            {
                total += 10;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }
            if (chk5.Checked)
            {
                total += 5.50;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }
            if (chk15.Checked)
            {
                total += 15.98;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }
            if (chk6.Checked)
            {
                total += 6.30;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }
            if (chk9.Checked)
            {
                total += 9;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }
            if (chk20.Checked)
            {
                total += 20;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }
            if (chk4.Checked)
            {
                total += 4.12;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }
            if (chk12.Checked)
            {
                total += 12.65;
                txttotal.Clear();
                txttotal.Text = total.ToString();
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
