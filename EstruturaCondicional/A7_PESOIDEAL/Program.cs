using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_PESOIDEAL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double altura, pesoIdeal = 0;
            string sexo;

            Console.WriteLine("Informe a altura da pessoa: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo da pessoa: ");
            sexo = Console.ReadLine();


            if(sexo == "F" || sexo == "f" || sexo == "feminino")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            } else if (sexo == "M" || sexo == "m" || sexo == "masculino")
            {
                pesoIdeal = (72.7 * altura) - 58;
            }

            Console.WriteLine("O pesoa ideal dessa pessoa deve ser: " + pesoIdeal);

            Console.ReadKey();

        }
    }
}
