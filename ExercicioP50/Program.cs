using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioP50
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 50");
            // 50. Fazer os métodos descritos logo abaixo:

            //1 - Fazer método C# que recebe 2 números double e retorna a soma dos números
            double resultadoSoma = NumSoma(5,5);
            Console.WriteLine(resultadoSoma);

            //2 - Fazer método C# que recebe 2 números double e retorna a soma dos números
            double resultadoMultiplicacao = NumMulti(5, 5);
            Console.WriteLine(resultadoMultiplicacao);

            //3 – Fazer método C# que recebe 2 números double e retorna a subtração dos números
            double resultadoSubtração = NumSub(10, 2);
            Console.WriteLine(resultadoSubtração);

            //4 – Fazer método C# que recebe 1 número double e retorna a raiz quadrada do numero
            double resultadoRaiz = RaizQuadrada(20);
            Console.WriteLine(resultadoRaiz);
            
            Console.ReadLine();
        }
        public static double NumSoma(double x1, double x2)
        {
            return(x1 + x2);
        }
        public static double NumMulti(double x1, double x2)
        {
            return (x1 * x2);
        }
        public static double NumSub(double x1, double x2)
        {
            return (x1 - x2);
        }
        public static double RaizQuadrada(double x1)
        {
            return (Math.Sqrt(x1));
        }
    }
}
