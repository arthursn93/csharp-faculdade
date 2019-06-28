using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 33");
            // 33. Construa um algoritmo para somar e contar os números pares e ímpares de 20 números introduzidos pelo usuário.

            int somaP = 0;
            int somaI = 0;

            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Informe o  número: ");
                int b = int.Parse(Console.ReadLine());

                if(b % 2 != 1)
                {                   
                    Console.WriteLine("Par: " + b);

                    somaP += b;
                    Console.WriteLine("Somando números Pares: " + somaP);
                }
                else
                {
                    Console.WriteLine("Ímpar: " + b);

                    somaI += b;
                    Console.WriteLine("Somando números Ímpares: " + somaI);
                }
            }

            Console.WriteLine("Total Par: " + somaP + "; " + "Total Ímpar: " + somaI);

            int somaTotal = somaP + somaI;
            Console.WriteLine("Soma total: " + somaTotal);

            Console.ReadLine();
        }
    }
}
