using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pag62_n10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0 , resultado=1;


            Console.WriteLine("digite um numero positivo:");
            numero = int.Parse(Console.ReadLine());


            while(numero > 0)
            {
                resultado = resultado * numero;
                numero--;

            }
            
            Console.WriteLine("o resultado é: " + resultado);

            Console.ReadKey();






        }
    }
}
