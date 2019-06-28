using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 37");
            Console.WriteLine(" ");
            // 37. Escreva um algoritmo que leia 50 valores e encontre o maior e o menor deles. Mostre o resultado.

            int z, menor = 0, maior = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("informe o valor: ");
                z = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    menor = z;
                    maior = z;
                }
                else if (z <= menor)
                {
                    menor = z;
                }
                else if (z >= maior)
                {
                    maior = z;
                }
                
            }
            Console.WriteLine("MAIOR: " + maior);
            Console.WriteLine("MENOR: " + menor);

            Console.ReadLine();
        }
    }
}
