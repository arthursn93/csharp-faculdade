using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 44");
            // 44. Use array de 5 valores e mostre a posição oposta da mesma.
            int[] vnota = new int[5];

            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite o número: ");
                vnota[i] = int.Parse(Console.ReadLine());
            }

            for (int x = 4; x >= 0; x--)
            {
                Console.WriteLine("Na posição oposta");
                Console.WriteLine(vnota[x]);
            }
            Console.ReadLine();
        }
    }
}
