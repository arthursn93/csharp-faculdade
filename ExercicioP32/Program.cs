using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 32");
            // 32. Apresente o total da soma de todos os números inteiros múltiplos de 4 que sejam menores que 200, iniciando a contagem em 1.

            int x = 0;

            for(int i = 1; i <= 200; i++)
            {
                if(i % 4 == 0)
                {
                    x += i;
                }
            }
            Console.WriteLine("Total = " + x);

            Console.ReadLine();
        }
    }
}
