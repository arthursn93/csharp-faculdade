using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP49
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 49");
            // 49. Faça o Vetor (Array) de 5 valores inteiros, e retorne apenas os valores Ímpares.

            int[]m = new int[5];

            for(int i=1; i<5; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Número: " + m[i]);
                Console.WriteLine(" ");

            }
            vImpar(m);

            Console.ReadLine();
        }
        public static void vImpar(int[] m)
        {
            for(int i=1; i<5; i++)
            {
                if(m[i] % 2 == 1)
                {
                    Console.WriteLine("Número Ímpar :" + m[i]);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
