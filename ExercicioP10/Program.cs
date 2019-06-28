using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 10");
            //10.Escreva um programa que calcule a média aritmética de três números digitados pelo usuário.

            Console.WriteLine("Informe o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número: ");
            double c = double.Parse(Console.ReadLine());

            double mediaAri = (a + b + c) / 3 ;
            Console.WriteLine("Média Aritmética = " + mediaAri);

            Console.ReadLine();
        }
    }
}
