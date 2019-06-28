using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 12");
            /* 12.Escreva um programa que leia o nome de um aluno e as notas que ele obteve nas três provas do semestre. 
             * No final, o programa deve informar o nome do aluno e a sua média aritmética.*/

            Console.WriteLine("Informe o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota do aluno: ");            
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota do aluno: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota do aluno: ");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;
            Console.WriteLine("Aluno " + nomeAluno + " tem a média: " + media);

            Console.ReadLine();
        }
    }
}
