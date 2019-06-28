using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 26");
            // 26. Faça um algoritmo que pega números ímpares numa escala de 100 a 300.
            for (int i=100; i<=300; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }     
            }
            Console.ReadLine();
        }
    }
}
