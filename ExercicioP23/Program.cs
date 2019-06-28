using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 23");
            // 23. Fazer programa que lê 3 numeros diferentes e escreva em ordem decrescente.
            int aux = 0;

            Console.Write("Informe a variavel A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a variavel B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a variavel C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a < c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b < c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine("Valores Ordenados em Ordem Decrescente: " + a + ", " + b + ", " + c);

            Console.ReadLine();
        }
    }
}
