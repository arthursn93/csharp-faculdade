using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 31");
            // 31. Apresente o total da soma dos valores númericos inteiros ímpares situados na faixa de 0 a 20.

            int x = 0;

            for(int i = 0; i <= 20; i++)
            {
                if(i % 2 != 0)
                {
                    x += i;                   
                }
            }
            Console.WriteLine("Total da soma: " + x);

            Console.ReadLine();
        }
    }
}
