using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 38");
            // 38. Dados: 10 números digitados pelo usuário. Construa algoritmo para mostrar os valores negativos e que calcule e mostre a média dos valores menores que zero.

            double vP, vN = 0, aC = 0, n, mE;
            int cO = 0;

            for(int i=0; i<=10; i++)
            {
                Console.WriteLine("Informe o número: ");
                Console.WriteLine(" ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                if (n == 0 || n > 0)
                {
                    vP = n;
                }
                else if (n <= 0)// se o valor for negativo -> mostra números negativos, soma dos números negativos e faz contagem.
                {
                    vN = n;
                    aC += vN;                    
                    cO++;
                    vN = 0;
                    Console.WriteLine("valor negativo: " + n);
                    Console.WriteLine(" ");
                }
                
                Console.WriteLine("Soma dos valores negativos: " + aC);
                Console.WriteLine(" ");
                Console.WriteLine("Contagem de vezes: " + cO);
                Console.WriteLine(" ");

            }
            mE = aC / cO; // média da soma dos valores negativos pela contagem de vezes que foi digitado o número negativo
            Console.WriteLine("Média dos valores negativos: " + mE);
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
