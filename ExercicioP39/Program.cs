using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 39");
            // 39. Elabore um algoritmo para efetuar a soma de todos os números pares que se encontram no conjunto de números de 1 até 20.

            int x = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 1)
                {
                    x += i;
                }
            }
            Console.WriteLine("Total Par: " + x);

            Console.ReadLine();
        }
    }
}
