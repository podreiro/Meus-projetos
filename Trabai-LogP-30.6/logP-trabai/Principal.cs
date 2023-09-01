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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exercicio1 ex1  = new exercicio1();
            ex1.ShowDialog();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio2 ex2 = new Exercicio2();
            ex2.ShowDialog();
             
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exercicio3 ex3 = new exercicio3();
            ex3.ShowDialog();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exercicio4 ex4 = new exercicio4();
            ex4.ShowDialog();
        }
    }
}
