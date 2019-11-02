using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioD
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[10];
            double[,] c = new double[10, 3];
            int i, j, k;

            for (i=0; i<10; i++)
            {
                Console.Write("Digite um valor para A[{0}]: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }

            for (i=0; i<10; i++)
            {
                j = 0;
                c[i, j] = a[i] + 5;
                j = 1;
                c[i, j] = 1;
                for (k=1; k<=a[i]; k++)
                {
                    c[i, j] = c[i,j] * k;
                }
                j = 2;
                c[i, j] = Math.Pow(a[i], 2);
            }

            for (i=0; i<10; i++)
            {
                for (j=0; j<3; j++)
                {
                    Console.WriteLine("C[{0}-{1}] = {2}", i + 1, j + 1, c[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
