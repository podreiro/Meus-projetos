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
    public partial class Desafio : Form
    {
        public Desafio()
        {
            InitializeComponent();
        }

        private void Desafio_Load(object sender, EventArgs e)
        {

        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            int numero1;

            numero1 = int.Parse(btncriar.Text);

            int[] vetor = new int[numero1];

        }
    }
}
