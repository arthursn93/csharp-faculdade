using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 14");
            /* 14. Efetue a leitura de uma temperatura em graus Celsius e faça a conversão
                em graus Fahrenheit. A fórmula para a conversão das temperaturas 
                é: F = (9 * C + 160) / 5, sendo F a temperatura em graus Fahrenheit e C em Celsius; */

            bool a = true;
            while (a)
            {
                Console.WriteLine("Quantos graus celsius?");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
           
                double f = (9 * c + 160) / 5;

                Console.WriteLine(f + " Fº");
                Console.WriteLine(" ");
            }           
            Console.ReadLine();
        }
    }
}
