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
            double[] a = new double[12];
            int i, j;
            double x;

            for (i=0; i<12; i++)
            {
                Console.Write("Digite o {0}º valor de A: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }

            for (i=0; i<12; i++)
            {
                for (j=i+1; j<12; j++)
                {
                    if (a[i] > a[j])
                    {
                        x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }
            
            for (i=0; i<12; i++)
            {
                Console.WriteLine("O {0}º valor de A é {1}.", i + 1, a[i]);
            }
            Console.ReadKey();
        }
    }
}
