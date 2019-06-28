using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP45
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 45");
            // 45. Retorne a raiz quadrada de um 4 números especificados.

            double d = dist(4,2,4,2);
            Console.WriteLine(d);

            Console.ReadLine();
        }
        public static double dist(double x1, double y1, double x2, double y2)
        {
            return (Math.Sqrt((x1 - y1) * (x1 - y1) + (x2 - y2) * (x2 - y2)));
        }
    }
}


