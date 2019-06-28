using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP48
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 48");
            // 47. Calcule 5 números aleatórios dentro de uma função SomaVetor que vai receber um vetor nota com 70 posições. Mostre o resultado na tela!

            int i;
            double[] nota = new double[70];
            double somaNota = 0, media;

            for(i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe o número: ");
                nota[i] = double.Parse(Console.ReadLine());              
            }
            somaNota = Somavetor(nota);

            media = somaNota / 70;

            Console.WriteLine(media);

            Console.ReadLine();
        }
        public static double Somavetor(double[]nota)
        {
            int i;
            double x = 0;

            for(i = 0; i < 4; i++)
            {
                x += nota[i];
            }
            return x;
        }

    }
}
