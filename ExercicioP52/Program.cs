using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP52
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 52");
            // 52. Fazer método C# que recebe 1 vetor de número inteiros em ordem crescente e retorna na ordem decrescente.

            int[] m = new int[5];

            Console.WriteLine("Crescente - ");
            Console.WriteLine(" ");

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Nº ");
                m[i] = int.Parse(Console.ReadLine());
            }
            Oposto(m);

            Console.ReadLine();
        }
        public static void Oposto(int[] m)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Decrescente - ");
            Console.WriteLine(" ");

            for (int i = 4; i >= 0; i--)
            {
                Console.Write("Nº ");
                Console.WriteLine(m[i]);
            }
        }
    }
}

