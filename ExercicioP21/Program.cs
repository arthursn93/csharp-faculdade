using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercícioP21
{
    class Program
    {

        static void Main(String[] Args)
        {
            Console.WriteLine("Exercicio 21");
            // 21. Crie um algoritmo que obtem o valor da área de um Triângulo (Equilátero, Isósceles e Escaleno).

            Console.WriteLine("Informe o lado A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o lado B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o lado C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if ((A == B) && (B == C))
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if ((A == B) || (B == C) || (A == C))
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }

            Console.ReadLine();
        }
    }

}