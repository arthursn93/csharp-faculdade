using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 6");
            // 6. Faça um algoritmo que receba um número e diga se este está ou não no intervalo entre 200 e 300.
            Console.WriteLine("Informe o número: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 200 && n <= 300)
            {
                Console.WriteLine("O número " + n + " está entre 200 e 300!");
            }
            else
            {
                Console.WriteLine("O número " + n + " não está entre 200 e 300!");
            }

            Console.ReadLine();
        }
    }
}
