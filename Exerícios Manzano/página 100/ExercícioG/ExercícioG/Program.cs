using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioG
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[4, 4];
            int i, j;
            double aux=0;

            for (i=0; i<4; i++)
            {
                for (j=0; j<4; j++)
                {
                    Console.Write("Digite A[{0}-{1}]: ", i + 1, j + 1);
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (i=0; i<4; i++)
            {
                for (j=0; j<4; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        aux = aux + 1;
                    }
                }
            }

            Console.Write("A matriz possui {0} elementos pares.", aux);
            Console.ReadKey();
        }
    }
}
