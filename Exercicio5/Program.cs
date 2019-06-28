using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5");
            /*5. Crie um algoritmo que leia dois valores inteiros e informe se eles são iguais. 
             * Caso sejam diferentes, informe qual deles é maior.*/

            Console.WriteLine("Informe o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("O primeiro valor é " + a + " e é MAIOR que o segundo valor " + b);
            }
            else if (b > a)
            {
                Console.WriteLine("O primeiro valor é " + a + " e é MENOR que o segundo valor " + b);
            }
            else if( a == b)
            {
                Console.WriteLine(" O primeiro valor e o segundo valor são iguais: " + a + " e " + b);
            }
            Console.ReadLine();
        }
    }
}
