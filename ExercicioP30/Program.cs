using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 30");
            // 30. Fazer um programa que mostra a soma dos números pares numa escala entre 47 e 93.

            int soma = 0;

            for(int i=47; i <=93; i++)
            {
                if(i % 2 != 1)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}
