using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 13");
            //13. Escreva um programa que receba um número e diga se ele está no intervalo entre 100 e 200.

            bool i = true;

            while (i)
            {
                Console.WriteLine("Informe o número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                if (a >= 100 && a <= 200)
                {
                    Console.WriteLine("O número " + a + " está no intervalo entre 100 e 200!");
                }
                else
                {
                    Console.WriteLine("O número " + a + " NÃO está no intervalo entre 100 e 200!");
                }
            }            
            Console.ReadLine();
        }
    }
}