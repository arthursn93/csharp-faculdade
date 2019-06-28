using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 9");
            // 9.Escreva um programa que diga qual é o maior de dois números distintos.
            Console.WriteLine("Informe o primeiro número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double b = double.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("O primeiro número " + a + " é maior que o segundo número " + b);
            }
            else
            {
                Console.WriteLine("O segundo número " + b + " é maior que o primeiro número " + a);
            }
            Console.ReadLine();
        }
    }
}
