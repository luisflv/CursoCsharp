using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_ALUNOAPRREPR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double media;

            Console.WriteLine("Informe a média final do aluno: ");
            media = double.Parse(Console.ReadLine());   

            if(media >= 0 && media <= 4.9)
            {
                Console.WriteLine("REPROVADO!");
            } else if (media >= 5 && media <= 6.9)
            {
                Console.WriteLine("EM RECUPERAÇÃO!");
            } else if (media >= 7 && media <= 10)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("Você informou um valor inválido. Tente novamente.");
            }

            Console.ReadKey();

        }
    }
}
