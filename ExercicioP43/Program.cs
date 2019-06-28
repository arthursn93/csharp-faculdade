using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP43
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 43");
            /*  43. Foi feita uma pesquisa entre os 1000 habitantes de uma região para coletar os
                   seguintes dados: sexo (0-feminino, 1-masculino), idade e altura. Faça um algoritmo
                   que leia as informações coletadas e mostre as seguintes informações:
                   a) média da idade do grupo;
                   b) média da altura das mulheres;
                   c) média da idade dos homens;
                   d) percentual de pessoas com idade entre 18 e 35 anos (inclusive).  */

            int ida = 0, sex;
            double fe = 0, idaFem = 0, ma = 0, alt, altFem = 0, altMasc = 0, altMediaFem = 0, idaMediaMasc = 0, idaMasc = 0, idaMediaGrupo = 0, idaMediaFem = 0, Porcent, idaP = 0;

            Console.WriteLine("Qual é o seu sexo? ");
            Console.WriteLine(" ");
            Console.WriteLine("Feminino == Digite 0 ");
            Console.WriteLine("Masculino == Digite 1 ");
            Console.WriteLine(" ");

            for (int i = 0; i <=999; i++)
            {
                Console.WriteLine("Masculino ou Feminino?");
                sex = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Idade?");
                ida = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Altura?");
                alt = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");


                if (sex == 0)
                {
                    fe++;
                    idaFem += ida;
                    altFem += alt;
                    Console.WriteLine("Feminino = " + fe + "; Idade = " + ida + "; Altura = " + alt);
                    Console.WriteLine(" ");
                }
                else if (sex == 1)
                {
                    ma++;
                    idaMasc += ida;
                    altMasc = alt;
                    Console.WriteLine("Masculino = " + ma + "; Idade = " + ida + "; Altura = " + alt);
                    Console.WriteLine(" ");
                }
                else if (sex <= 0 || sex >= 1)
                {
                    i--;
                    Console.WriteLine("Informe corretamente o seu sexo, tente de novo!");
                    Console.WriteLine(" ");
                    continue;
                }

                if (ida >= 18 && ida <= 35)
                {
                    idaP++;
                    Console.WriteLine("Contador: " + idaP);
                }
            }
            //Calculo para saber o percentual médio
            Porcent = idaP / 1000 * 100;
            Console.WriteLine("A porcentagem de pessoas entre 18 e 35 anos é: " + Porcent + "%");
            Console.WriteLine(" ");

            //Calculo para saber a altura média das mulheres
            altMediaFem = altFem / fe;
            Console.WriteLine("Altura média das mulheres = " + altMediaFem);
            Console.WriteLine(" ");

            //Calculo para saber a idade média dos homens
            idaMediaMasc = idaMasc / ma;
            Console.WriteLine("Idade média dos homens = " + idaMediaMasc);
            Console.WriteLine(" ");

            //Calculo para saber a idade média das mulheres
            idaMediaFem = idaFem / fe;
            Console.WriteLine("Idade média das mulheres = " + idaMediaFem);
            Console.WriteLine(" ");

            //Calculo para saber a idade média do grupo
            idaMediaGrupo = (idaMediaMasc + idaMediaFem)/2;
            Console.WriteLine("Idade média do grupo = " + idaMediaGrupo);
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
