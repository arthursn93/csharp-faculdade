using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 20");
            //20.Faça um algoritmo que mostre os números de 100 a 1, usando comando (use o comando WHILE ou FOR ) de repetição.

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine("Nº " + i);  
            }
            Console.ReadLine();
        }
    }
}
