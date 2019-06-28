using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 11");
            // 11.Escreva um programa que receba um número inteiro do usuário e diga se ele é par ou impar. Dica: Um número é par se o resto(use a função modulo %) da divisão dele por 2 for zero.

            bool i = true;

            while (i)
            {
                Console.WriteLine("Informe o número: ");
                int a = int.Parse(Console.ReadLine());

                if (a % 2 != 1)
                {
                    Console.WriteLine(" Par = " + a);
                }
                else
                {
                    Console.WriteLine(" Ímpar = " + a);
                }
            }
        }                            
    }
}

