using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");
            //1. Construa um algoritmo que calcule o valor da 
            //área de um triangulo, a partir do valor da base e altura.

            Console.WriteLine("Informe a base do triângulo:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo:");
            double a = double.Parse(Console.ReadLine());

            double calculo = b * a / 2.0;

            Console.WriteLine("o tamanho do triângulo é: " + calculo);
            Console.ReadLine();

        }
    }
}

