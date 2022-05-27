using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_TRIANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double lado1, lado2, lado3;

            Console.WriteLine("Informe o valor do primeiro lado: ");
            lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do segundo lado: ");
            lado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do terceiro lado: ");
            lado3 = double.Parse(Console.ReadLine());

            if( lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("De acordo com os valores infomados, o polígono é um triângulo equilátero!");
            }
            else
            {
                Console.WriteLine("De acordo com os valores infomados, o polígono não é um triângulo equilátero!");    
            }

            Console.ReadKey();

        }
    }
}
