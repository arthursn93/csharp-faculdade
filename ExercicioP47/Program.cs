using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 47");
            // 47. Calcule 5 números aleatórios em Vetor (Array) e mostre o resultado na tela.

            int i;
            double[] nota = new double[5];
            double somanota = 0;

            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe o número: ");
                nota[i] = double.Parse(Console.ReadLine());

                somanota += nota[i];
            }
            Console.WriteLine(somanota);

            Console.ReadLine();
        }
    }
}
