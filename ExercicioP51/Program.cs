using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP51
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 51");
            // 51. Fazer método C# que recebe 1 vetor de número inteiros e retorna a soma dos números ímpares.

            int[] n = new int[5];
            int a = 0;
            for(int i = 1; i< 5; i++)
            {
                Console.Write("Nº ");
                n[i] = int.Parse(Console.ReadLine());
            }
            a = ImparSoma(n);
            Console.WriteLine("Soma Total Nº Ímpares = " + a);

            Console.ReadLine();
        }
        public static int ImparSoma(int[] a)
        {
            int x = 0;

            for(int i = 1; i< 5; i++)
            {
                if(a[i] % 2 != 0)
                {
                    x += a[i];
                }
            }
            return x;
        }
    }
}
