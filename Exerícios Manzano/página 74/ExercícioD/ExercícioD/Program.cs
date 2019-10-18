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
            int z;
            double[] a = new double[15];
            double[] b = new double[15];

            for (z=0; z<15; z++)
            {
                Console.Write("Digite o {0}º valor de A: ", z+1);
                a[z] = double.Parse(Console.ReadLine());
            }
            for(z=0; z < 15; z++)
            {
                b[z] = Math.Pow(a[z], 2);
                Console.WriteLine("{0}²={1}", a[z], b[z]);
            }
            Console.ReadKey();
        }
    }
}
