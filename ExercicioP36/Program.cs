using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 36");
            Console.WriteLine(" ");
            // 36. Numa danceteria, numa noite, estiveram 150 clientes, desses, muitos pagaram suas contas com cheque, cartão de credito e cédulas. 
            // Construa algoritmo para somar o total de valores pagos em cédulas, cheques e cartões de credito, e a receita total que obteve a danceteria.
            int c = 0, cC = 0, cH = 0, x;

            double rT = 0, n;

            Console.WriteLine("Cédula == digite 1 ");
            Console.WriteLine("Cartão de Crédito == digite 2 ");
            Console.WriteLine("Cheque == digite 3 ");


            for (int i = 0; i <= 149; i++)
            {
                Console.WriteLine("Informe o método de pagamento: ");
                x = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    c++;
                    x = 0;
                }
                else if (x == 2)
                {
                    cC++;
                    x = 0;
                }
                else if (x == 3)
                {
                    cH++;
                    x = 0;
                }
                else if (x > 3 || x < 1)
                {
                    Console.WriteLine("Error 404, digite a tecla novamente!");
                }

                Console.WriteLine("Quanto foi o valor pago?");
                n = double.Parse(Console.ReadLine());
                rT = rT + n;
                n = 0;
            }
            Console.WriteLine("Total Cédula - " + c);
            Console.WriteLine("Total Cartão de Crédito - " + cC);
            Console.WriteLine("Total Cheque - " + cH);
            Console.WriteLine("Receita Total Danceteria - " + rT);

            Console.ReadLine();
        }
    }
}
