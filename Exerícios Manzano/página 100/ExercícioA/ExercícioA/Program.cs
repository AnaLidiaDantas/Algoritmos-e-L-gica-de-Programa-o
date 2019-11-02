using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioA
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[5, 3];
            double[,] b = new double[5, 3];
            double[,] c = new double[5, 3];
            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor para A {0} - {1}: ", i + 1, j + 1);
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor para B {0} - {1}: ", i + 1, j + 1);
                    b[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < 5; i++)
            {
                for (j=0;j<3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.WriteLine("O valor de A[{0}-{1}] somado com o valor de B[{0}-{1}] é igual a {2}", i + 1, j + 1, c[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
