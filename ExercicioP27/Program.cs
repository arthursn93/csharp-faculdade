using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 27");
            // 27. Faça um algoritmo que calcule a escala de 1 a 1000.

            int soma = 0;

            for(int i=1; i<=1000; i++)
            {
                soma += i;
            }
            Console.WriteLine("Total = " + soma);

            Console.ReadLine();
        }
    }
}
