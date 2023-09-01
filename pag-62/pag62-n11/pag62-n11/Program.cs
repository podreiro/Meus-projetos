using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pag62_n11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0,resultados, cont = 100;
        
            Console.WriteLine("digite o numero");
            numero = int.Parse(Console.ReadLine());
            while (numero != -1)
            {


                for (cont = numero; cont >= 1; cont--)
                {
                    resultados = numero % cont;

                    if (resultados == 0)
                    {
                        Console.WriteLine(cont);
                    }

                }
                
                Console.WriteLine("digite o numero");
                numero = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            Console.ReadKey();
        }
    }
}
