using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioF
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[7, 7];
            double[,] c = new double[7, 7];
            int i, j, x;

            for (i=0; i<7; i++)
            {
                for (j=0; j<7; j++)
                {
                    Console.Write(" Digite A[{0}-{1}]: ", i, j);
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }
            
            for (i=0; i<7; i++)
            {
                for (j=0; j<7; j++)
                {
                    if (i != j)
                    {
                        c[i, j] = a[i, j] + i + j;
                    }
                    else
                    {
                        c[i, j] = 1;
                        for (x=1; x<=a[i,j]; x++)
                        {
                            c[i, j] = c[i, j] * x;
                        }
                    }
                }
            }

            for (i=0; i<7; i++)
            {
                for (j=0; j<7; j++)
                {
                    Console.WriteLine("C[{0}-{1}] = {2}", i, j, c[i, j]);
                }
            }

            Console.ReadKey();

        }
    }
}
