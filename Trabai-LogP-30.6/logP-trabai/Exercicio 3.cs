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
    public partial class exercicio3 : Form
    {
        public exercicio3()
        {
            InitializeComponent();
        }

        private void btnMudarDeCor_Click(object sender, EventArgs e)
        {
            if ( rdbCorVerde.Checked ) 
            {

                BackColor = Color.Gray;

            }

            if (rdbCorVermelho.Checked)
            {

                BackColor = Color.Pink;

            }

            if (rdbCorAmarelo.Checked)
            {

                BackColor = Color.Purple;

            }
        }
    }
}
