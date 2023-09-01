using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logP_trabai
{
    public partial class exercicio1 : Form
    {
        public exercicio1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void LstNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            

          
        }

        private void cmbFim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorIni = 0, valorFim = 0;

            //qual o valor do combobox 1
            switch (cmbInicio.SelectedIndex)

            {
                case 0:
                    valorIni = 1;
                    break;

                case 1:
                    valorIni = 2;
                    break;

                case 2:
                    valorIni = 3;
                    break;

                case 3:
                    valorIni = 4;
                    break;

                case 4:
                    valorIni = 5;
                    break;

                case 5:
                    valorIni = 6;
                    break;

                case 6:
                    valorIni = 7;
                    break;

                case 7:
                    valorIni = 8;
                    break;

                case 8:
                    valorIni = 9;
                    break;

                case 9:
                    valorIni = 10;
                    break;


            }
            //qual o valor do combobox 2
            switch (cmbFim.SelectedIndex)

            {
                case 0:
                    valorFim = 1;
                    break;

                case 1:
                    valorFim = 2;
                    break;

                case 2:
                    valorFim = 3;
                    break;

                case 3:
                    valorFim = 4;
                    break;

                case 4:
                    valorFim = 5;
                    break;

                case 5:
                    valorFim = 6;
                    break;

                case 6:
                    valorFim = 7;
                    break;

                case 7:
                    valorFim = 8;
                    break;

                case 8:
                    valorFim = 9;
                    break;

                case 9:
                    valorFim = 10;
                    break;
            }
            LstNumeros.Items.Clear();
            // se o 1 numero for menor 
            if (valorIni < valorFim)
            {
                for (int i = valorIni, f = valorFim; i < f + 1; i++)
                {
                    LstNumeros.Items.Add(i);
                }

            }
            //se o 1 numero for maior
            if (valorIni > valorFim)
            {
                for (int f = valorFim, i = valorIni; i > f - 1; i--)
                {
                    LstNumeros.Items.Add(i);
                }
            }
        }
    }
}
