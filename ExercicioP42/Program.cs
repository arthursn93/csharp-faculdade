using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP42
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 42");
            /*  12. Em uma eleição presidencial, existem dois candidatos. Os votos são informados através de código. Os dados utilizados obedecem à seguinte codificação:
                1 e 2 = voto para os respectivos candidatos;
                3 = voto em branco;
                4 = voto nulo.
                Elabore um algoritmo que calcule e escreva:
                a) total de votos para cada candidato;
                b) total de votos brancos;
                c) total de votos nulos;
                d) total de votos lidos;
                e) mostre o candidato vencedor.  */

            int Bonoro = 0, Lulex = 0, vB = 0, vN = 0, tvL, tBonoro, tLulex, tvB, tvN, n;

            Console.WriteLine("Para votar em Bonoro == Digite a tecla 1: ");
            Console.WriteLine(" ");
            Console.WriteLine("Para votar em Lulex == Digite a tecla 2: ");
            Console.WriteLine(" ");
            Console.WriteLine("Para votar em Branco == Digite a tecla 3: ");
            Console.WriteLine(" ");
            Console.WriteLine("Para votar em Nulo == Digite a tecla 4: ");
            Console.WriteLine(" ");

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Informando o número: ");
                n = int.Parse(Console.ReadLine());

                if(n == 1)
                {
                    Bonoro++;
                    Console.WriteLine("Bonoro = " + Bonoro);
                }
                else if(n == 2)
                {
                    Lulex++;
                    Console.WriteLine("Lulex = " + Lulex);
                }
                else if(n == 3)
                {
                    vB++;
                    Console.WriteLine("Voto Branco = " + vB);
                }
                else if(n == 4)
                {
                    vN++;
                    Console.WriteLine("Voto Nulo = " + vN);
                }
                else if(n >= 4 || n <= 1)
                {
                    i--;
                    Console.WriteLine("Esse número não existe, por favor digitar de novo na tela!");
                    Console.WriteLine(" ");
                    continue;
                }
            }

            tBonoro = Bonoro;
            Console.WriteLine("Total de votos - Candidato Bonoro = " + tBonoro);

            tLulex = Lulex;
            Console.WriteLine("Total de votos - Candidato Lulex = " + tLulex);

            tvB = vB;
            Console.WriteLine("Total de votos - Branco = " + tvB);

            tvN = vN;
            Console.WriteLine("Total de votos - Nulo = " + tvN);

            tvL = Bonoro + Lulex + vB + vN;
            Console.WriteLine("Total Votos lidos: " + tvL);

            if(tBonoro > tLulex && tBonoro > tvB && tBonoro > tvN)
            {
                Console.WriteLine("O candidato vencedor das eleições 2019 é Bonoro Taokey Arminha! ");
            }
            else if(tLulex > tBonoro && tLulex > tvB && tLulex > tvN)
            {
                Console.WriteLine("O candidato vencedor das eleições 2019 é Lulex 51 da Silva");
            }
            else if(tvB > tBonoro && tvB > tLulex && tvB > tvN)
            {
                Console.WriteLine("Nenhum candidato venceu, Votos em Branco recebe mais votos!");
            }
            else if(tvN > tBonoro && tvN > tLulex && tvN > tvB)
            {
                Console.WriteLine("Nenhum candidato venceu, Votos em Nulo recebe mais votos!");
            }
            else if(tBonoro == tLulex)
            {
                Console.WriteLine("Houve empate entre os candidatos. Vamos ao segundo turno!");
            }
            else if(tLulex == tvB || tLulex == tvN || tBonoro == tvB || tBonoro == tvN)
            {
                Console.WriteLine("Votos nulos ou branco estão iguais ao do candidato. Será preciso fazer um segundo turno!");
            }

            Console.ReadLine();
        }
    }
}
