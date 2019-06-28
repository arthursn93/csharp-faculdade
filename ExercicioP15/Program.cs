using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 15");
            /* 15. Efetue a leitura de uma temperatura medida em graus Fahrenheit e a apresente
             * con-vertida em graus Celsius. A fórmula para a conversão é C = ((F-32)*5)/9,
             * sendo F a temperatura em Fahrenheit e C a temperatura em Celsius. */
            bool a = true;

            while (a)
            {
                Console.WriteLine("Quantos graus Fahrenheit?");
                double f = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                double c = ((f - 32) * 5) / 9;

                Console.WriteLine(c + " Cº");
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
