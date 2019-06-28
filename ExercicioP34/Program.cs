using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 34");
            // 34. Escreva um programa que calcule a área de vários círculos de raio r, até que o usuário digite 0.

            bool i = true;
            double pi = 3.141592, r;
            while (i)
            {
                Console.WriteLine("digite o valor do raio: ");
                r = double.Parse(Console.ReadLine());

                double area = pi * r * r;
                Console.WriteLine("o raio do circulo será: " + area);

                if (r == 0)
                {
                    Console.WriteLine("Digitou o número " + r + ", por essa razão a contagem é finalizada.");
                    break;
                }
            }            
            Console.ReadLine();
        }
    }
}
