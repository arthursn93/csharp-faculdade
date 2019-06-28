using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 3");

            /* 3. Elabore um algoritmo que leia o nome de um vendedor, o seu salario fixo e o total
             * de vendas efetuadas por ele no mês (em dinheiro). Sabendo que esse vendedor
             * ganha 20% de comissão sobre suas vendas efetuadas, faça que o algortimo informe
             * o seu nome, o salario fixo e o salario no final do mês;*/

            Console.WriteLine("Informe o nome do vendedor: ");
            string nomeVendedor = Console.ReadLine();

            Console.WriteLine("Informe o seu salário fixo: ");
            double salarioFixo = double.Parse(Console.ReadLine());

            double comissao = 0.20;
            Console.WriteLine("Você recebeu " + comissao + "% de comissão durante 1 mês");

            double salarioComi = salarioFixo * comissao;
            double salarioFinal = salarioComi + salarioFixo;
            Console.WriteLine("O vendedor " + nomeVendedor + " ganha R$" + salarioFixo + " de salário fixo. Receberá no final do mês R$" + salarioComi + " de comissão" + ", sendo assim, o seu salário final será de R$" + salarioFinal);

            Console.ReadLine();
        }
    }
}
