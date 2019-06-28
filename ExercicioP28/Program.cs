using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 28");
            // 28. Fazer um programa que mostra os numeros divisiveis por 7 entre 1 e 100.
            for (int i=1; i<=100; i++)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
            Console.ReadLine();
        }
    }
}
