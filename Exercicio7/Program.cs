using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace Exercicio7
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 7");
            /* 7.Escreva um programa que resolva o seguinte problema: uma cópia "xerox" custa R$ 0,50
             * por folha, mas acima de 200 folhas esse valor cai para R$ 0,30 por unidade. Dado o total
             * de cópias, informe o valor a ser pago */
          
            Console.WriteLine("Informe quantas cópias serão xerocada: ");
            int x = int.Parse(Console.ReadLine());        

            double precoXerox1 = 0.50;
            double precoXerox2 = 0.30;

            if (x >= 200)
            {
                Console.WriteLine("O preço do xerox para cada unidade será: " + precoXerox2);
            }
            else
            {
                Console.WriteLine("O preço do xerox para cada unidade será: " + precoXerox1);
            }

            Console.ReadLine();
        }
    }
}
