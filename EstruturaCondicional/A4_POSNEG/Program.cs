using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4_POSNEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double numero;

            Console.WriteLine("Informe um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número " + numero + " é positivo!");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número " + numero + " é negativo!");
            }
            else
            {
                Console.WriteLine("O número " + numero + " é nulo!");
            }
            Console.ReadKey();

        }
    }
}
