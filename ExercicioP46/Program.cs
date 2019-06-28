using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP46
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 46");
            // 46. Retorne 1 número inteiro e 2 multiplicações distintas em 2 funções diferentes.

            Console.Write("Retorna Nº: ");
            imp(6);

            Console.Write("Retorna Nº Multiplicado: ");
            int a = areaQuad(2);
            imp(a);

            Console.Write("Retorna Nº Multiplicado: ");
            int b = areaQuad1(5);
            imp(b);

            Console.ReadKey();
        }
        public static void imp (int x)
        {
            Console.WriteLine(x);
        }
        public static int areaQuad(int y)
        {
            return (y * y);
        }
        public static int areaQuad1(int z)
        {
            return (z * z);
        }
    }
}
