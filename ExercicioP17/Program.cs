using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 17");
            /* 17.Efetue a leitura de quatro valores reais referentes a quatro notas escolares de
             * um aluno e apresente mensagem informando que o aluno está aprovado caso o valor da
             * média escolar seja maior ou igual a 5. Caso o aluno não seja aprovado, apresente
             * mensagem informando que o aluno encontra-se reprovado. Ao final, além das mensagens,
             * apresente o valor da média do aluno.*/

            Console.Write("Informe a 1º nota: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Informe a 2º nota: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Informe a 3º nota: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Informe a 4º nota: ");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double media = (n1 + n2 + n3 + n4) / 4;

            if(media >= 5)
            {
                Console.WriteLine("média: " + media + " - está aprovado.");
            }
            else
            {
                Console.WriteLine("média: " + media + " - está reprovado.");
            }

            Console.ReadLine();
        }
    }
}
