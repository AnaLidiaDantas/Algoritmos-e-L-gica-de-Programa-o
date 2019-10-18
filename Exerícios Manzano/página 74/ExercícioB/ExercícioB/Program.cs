using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioB
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[8];
            double[] b = new double[8];
            int x;

            for (x=0; x<=7; x++)
            {
                Console.Write("Digite o {0}º número: ", x + 1);
                a[x] = double.Parse(Console.ReadLine());
            }
            for (x = 0; x <= 7; x++)
            {
                b[x] = a[x] * 3;
                Console.WriteLine("{0} X 3 = {1}", a[x], b[x]);
            }
            Console.ReadKey();
        }
    }
}
