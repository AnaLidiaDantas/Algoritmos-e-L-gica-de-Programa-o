using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioH
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] a = new double[5];
            double[] b = new double[5];
            double[] c = new double[5];
            double[] d = new double[15];

            for (i=0; i<5; i++)
            {
                Console.Write("Digite o {0}º valor de A: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }
            for (i=0; i<=4; i++)
            {
                Console.Write("Digite o {0}º valor de B: ", i + 1);
                b[i] = double.Parse(Console.ReadLine());
            }
            for (i=0; i < 5; i++)
            {
                Console.Write("Digite o {0}º valor de C: ", i + 1);
                c[i] = double.Parse(Console.ReadLine());
            }
            for (i=0; i < 5; i++)
            {
                d[i] = a[i];
            }
            for (i=5; i<10; i++)
            {
                d[i] = b[i - 5];
            }
            for (i=10; i < 15; i++)
            {
                d[i] = c[i - 10];
            }
            for (i=0; i < 15; i++)
            {
                Console.WriteLine("O {0}º valor de D é {1}", i + 1, d[i]);
            }
        Console.ReadKey();
        }
    }
}
