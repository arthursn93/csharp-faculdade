using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 40");
            //10. Calcular a soma de 10 números pares fornecidos pelo usuário, se o número for ímpar mostrar mensagem informando o usuário que o número é ímpar e mostrar o resultado da soma.

            int sP = 0, sI = 0, nU, cA;
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Informe o número: ");
                nU = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                if (nU % 2 == 0)
                {
                    sP += nU;
                }
                else if(nU % 2 == 1)
                {
                    sI += nU;
                    Console.WriteLine("Você digitou um número Ímpar: " + nU);
                    Console.WriteLine(" ");
                    
                }
            }
            Console.WriteLine("Soma dos números Ímpares: " + sI);
            Console.WriteLine(" ");
            Console.WriteLine("Soma dos números Pares: " + sP);
            Console.WriteLine(" ");

            cA = sI + sP;
            Console.WriteLine("Soma total dos números Pares e Ímpares: " + cA);
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
