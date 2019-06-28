using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 25");
            // 25. Escreva um programa que leia cinco valores e conte quantos desses valores são negativos, mostrando essa informação no final.

            int a, contador = 0, totalContador = 0;
            
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Informe o valor: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                if (a >= 0)
                {
                    Console.WriteLine("Nº Positivo: " + a);
                    Console.WriteLine(" ");

                }
                else
                {
                    Console.WriteLine("Nº Negativo: " + a);
                    Console.WriteLine(" ");
                    contador++;
                    Console.WriteLine(" ");
                }
            }
            totalContador += contador;
            Console.WriteLine("Total Nº Negativo = " + totalContador);
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
