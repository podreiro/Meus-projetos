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
    public partial class desafio1 : Form
    {
        public desafio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contParticipantes = 0, X = 0, Y=0, L=0, C=0, R= 0, P = 0,vencedor,menor,branco = 0,nulos = 0,numero,somanulos;

            
            contParticipantes++;
            numero = 0;
            numero = int.Parse(txtnumeros.Text);

         
            if (numero < 0 && numero > 6)
            {
                nulos++;
            }

            switch (numero)
            { 
                case 0 : branco++;
                    break;
                case 1: L++;
                    break;
                case 2: R++;
                    break;
                case 3: X++;
                    break;
                case 4: Y++;
                    break;
                case 5: P++;
                    break;
                case 6: C++;
                    break;
            }
            somanulos = branco + nulos;

            if ( L > R && L > X && L > Y && L > P && L > C)
            {
                vencedor = L;
            }

            if (R > L && R > X && R > Y && R > P && R > C)
            {
                vencedor = R;
            }

            if (X > R && X > L && X > Y && X > P && X > C)
            {
                vencedor = X;
            }

            if (Y > R && Y > X && Y > L && Y > P && Y > C)
            {
                vencedor = Y;
            }

            if (P > R && P > X && P > Y && P > L && P > C)
            {
                vencedor = P;
            }

            if (C > R && C > X && C > Y && C > P && C > L)
            {
                vencedor = C;
            }

        }
    }
}
