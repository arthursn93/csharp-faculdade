using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 29");
            // 29. Completar a musica dos patinhos da xuxa. N = patinhos / N -1 = -1 patinho

            for (int i = 5; i >= 1; i--)
            {
                int x = i;
                Console.WriteLine(i + " patinhos foram passear.");
                x--;
                Console.WriteLine("Mas apenas " + x + " voltaram para o lar.");
            }

            Console.ReadLine();
        }
    }
}
