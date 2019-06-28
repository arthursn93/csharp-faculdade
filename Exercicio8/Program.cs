using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 8");
            /* 8.Escreva um programa que informe a categoria de um jogador de futebol, 
             * considerando sua idade: infantil (até 13 anos), juvenil (até 17 anos) 
             * ou sênior (acima de 17 anos).*/

            Console.WriteLine("Informe a idade do jogador: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade <= 13)
            {
                Console.WriteLine("Você tem " + idade + " anos, então está na categoria infantil.");
            }
            else if (idade <= 14 || idade <= 17)
            {
                Console.WriteLine("Você tem " + idade + " anos, então está na categoria juvenil.");
            }
            else if(idade > 17)
            {
                Console.WriteLine("Você tem " + idade + " anos, então está na categoria sênior.");
            }

            Console.ReadLine();
        }
    }
}
