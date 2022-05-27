using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_MENORNUM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3;

            Console.WriteLine("Informe o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número: ");
            n3 = double.Parse(Console.ReadLine());


            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O número " + n1 + " é o maior.");
            }  else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O número " + n2 + " é o maior.");
            } else {
                Console.WriteLine("O número " + n3 + " é o maior.");
            }

            Console.ReadKey();
        }
    }
}
