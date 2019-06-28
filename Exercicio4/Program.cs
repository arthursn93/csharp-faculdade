using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4");
            /*4. Crie um algortimo que leia o nome de um aluno e as notas das três provas que
             * ele obteve no semestre, com pesos 2, 4 e 6. No final, deve-se informar o nome do
             * aluno e a sua média ponderada. */

            Console.WriteLine("Informe o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double mediaPonderada = (2*n1 + 4*n2 + 6*n3) / 12.0;
            Console.WriteLine("O aluno " + nomeAluno + " está com a média: " + mediaPonderada);
        
            Console.ReadLine();
        }
    }
}
