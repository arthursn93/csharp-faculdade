using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 22");
            /* 22. As maçãs custam R$ 0.30 se comprar menos que 12
             * As maçãs custam R$ 0.25 se comprar 12 ou mais.
             * Faça programa C# que lê o número de maçãs compradas e mostre o valor total*/


            Console.WriteLine("Quantas maçãs você deseja comprar? ");
            double m = double.Parse(Console.ReadLine());

            double valorMenor = 0.25;
            double valorMaior = 0.30;

            if (m >= 12)
            {
                Console.WriteLine("Você comprou " + m + " maçãs!");
                Console.WriteLine("Se compra 12 maçãs ou MAIS, vai lhe custar: R$ " + valorMaior + " cada.");
                Console.WriteLine(m *= valorMaior);
            }
            else if (m < 12)
            {
                Console.WriteLine("Você comprou " + m + " maçãs!");
                Console.WriteLine("Se compra MENOS que 12 maçãs, vai lhe custar: R$ " + valorMenor + " cada.");
                Console.WriteLine(m *= valorMenor);
            }
            Console.ReadLine();
        }
    }
}
