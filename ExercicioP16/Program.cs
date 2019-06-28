using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 16");
            // 16.Efetue a leitura de três valores (variáveis A, B e C) de qualquer tipo e apresente
            // os valores em ordem crescente.

            int aux = 0;

            Console.Write("Informe a variavel A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe a variavel B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Informe a variavel C: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine("Valores Ordenados em Ordem Crescente: " + a + ", " + b + ", " + c);

            Console.ReadLine();
        }
    }
}
