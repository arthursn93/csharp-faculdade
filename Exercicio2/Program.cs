using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2");
            // 2. Desenhe um algoritmo que receba dois números e mostre a soma, a subtração,
            // a multiplicação e a divisão dos números.

            Console.WriteLine("Informe o primeiro número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double b = double.Parse(Console.ReadLine());

            double calculoSoma = a + b;
            double calculoSubtracao = a - b;
            double calculoMultiplicacao = a * b;
            double calculoDivisao = a / b;

            Console.WriteLine("A soma de " + a + " + " + b + " é igual: " + calculoSoma);
            Console.WriteLine("A subtração de " + a + " - " + b + " é igual: " + calculoSubtracao);
            Console.WriteLine("A multiplicação de " + a + " x " + b + " é igual: " + calculoMultiplicacao);
            Console.WriteLine("A divisão de " + a + " / " + b + " é igual: " + calculoDivisao);


            Console.ReadLine();
        }
    }
}
