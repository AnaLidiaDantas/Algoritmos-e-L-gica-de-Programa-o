using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double[] a = new double[12];
            double[] b = new double[12];
            double[] c = new double[12];
            double[] z = new double[12];
            for (x = 0; x < 12; x++)
            {
                Console.Write("Digite o {0}º valor:", x + 1);
                z[x] = double.Parse(Console.ReadLine());
                if (z[x] % 2 == 0)
                {
                    a[x] = z[x];
                }
                else
                {
                    b[x] = z[x];
                }
            }
           for (x = 0; x < 12; x++)
            {
                Console.WriteLine("A = {0}", a[x]);
                Console.WriteLine("B = {0}", b[x]);
            }
            Console.ReadKey();
        }
    }
}
