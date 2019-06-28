using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 18");
            // 18. Efetue a leitura de dois valores numéricos inteiros e apresente o resultado
            // da diferença do maior valor pelo menor.

            Console.Write("Informe o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro valor " + n1 + " é maior que o segundo valor " + n2);
            }
            else
            {
                Console.WriteLine("O segundo valor " + n2 + " é maior que o primeiro valor " + n1);
            }

            Console.ReadLine();
        }
    }
}
