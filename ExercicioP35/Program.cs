using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 35");
            Console.WriteLine(" ");
            // 35. Escreva um programa que receba dez números inteiros do teclado e diga quantos são pares e quantos são ímpares

            int cCP = 0;
            int cCI = 0;

            int cP = 0;
            int cI = 0;

            for(int i = 0; i <=10; i++)
            {
                Console.WriteLine("Informe o número: ");
                Console.WriteLine(" ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                if (n % 2 == 0)
                {
                    cP = n;
                    Console.WriteLine("Recebe Par: " + cP);
                    Console.WriteLine(" ");

                    cCP++;
                    Console.WriteLine("Contagem: " + cCP);
                    Console.WriteLine(" ");
                }
                else
                {
                    cI = n;
                    Console.WriteLine("Recebe Ímpar: " + cI);
                    Console.WriteLine(" ");

                    cCI++;
                    Console.WriteLine("Contagem: " + cCI);
                    Console.WriteLine(" ");
                }
            }

            int sCP = cCP;
            int sCI = cCI;

            Console.WriteLine("Contagem Par: " + sCP + "; " + "Contagem Ímpar: " + sCI);
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
