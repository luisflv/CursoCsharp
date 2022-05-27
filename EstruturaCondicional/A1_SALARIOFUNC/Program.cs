using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_SALARIOFUNC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nomeFunc1, nomeFunc2;
            double salarioFunc1, salarioFunc2;

            Console.WriteLine("Informe o nome do primeiro funcionário: ");
            nomeFunc1 = Console.ReadLine();

            Console.WriteLine("Informe o salário do primeiro funcionário: ");
            salarioFunc1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do segundo funcionário: ");
            nomeFunc2 = Console.ReadLine();

            Console.WriteLine("Informe o salário do segundo funcionário: ");
            salarioFunc2 = double.Parse(Console.ReadLine());

            if (salarioFunc1 > salarioFunc2)
            {
                Console.WriteLine("O PRIMEIRO FUNCIONÁRIO POSSUI O SALÁRIO SUPERIOR AO SEGUNDO!");
                Console.WriteLine("Nome do funcionário: " + nomeFunc1);
                Console.WriteLine("Salário do funcionário: " + salarioFunc1);
            }
            else
            {
                Console.WriteLine("O SEGUNDO FUNCIONÁRIO POSSUI O SALÁRIO SUPERIOR AO PRIMEIRO!");
                Console.WriteLine("Nome do funcionário: " + nomeFunc2);
                Console.WriteLine("Salário do funcionário: " + salarioFunc2);
            }

            Console.ReadLine();

        }
    }
}
