using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 24");
            // 24. Apresente o total da soma dos valores numéricos inteiros ímpares situados numa escala de 0 a 20.

            Console.WriteLine("Valores ímpares: ");

            int[] numList = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int soma = 0;
            int somaa;

            for(int i = 0; i < numList.Length; i++)
            {
                somaa = soma += numList[i];
                Console.WriteLine("Nº Ímpar: " + numList[i]);
            }
            Console.WriteLine("Total: " + soma);

            Console.ReadLine();
        }
    }
}
