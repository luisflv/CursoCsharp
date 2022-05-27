using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_SALARIOVEND
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valorTotalVendas, salarioVendedor;

            Console.WriteLine("Informe o valor total de vendas do vendedor: ");
            valorTotalVendas = double.Parse(Console.ReadLine());

            if (valorTotalVendas >= 5000)
            {
                salarioVendedor = valorTotalVendas + (valorTotalVendas * 0.10);
            } else
            {
                salarioVendedor = valorTotalVendas + (valorTotalVendas * 0.75);
            }

            Console.WriteLine("O salário final do vendedor é: " + salarioVendedor);

            Console.ReadKey();

        }
    }
}
