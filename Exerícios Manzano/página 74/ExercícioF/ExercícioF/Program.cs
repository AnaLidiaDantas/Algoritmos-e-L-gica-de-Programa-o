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
            int x;
            double[] a = new double[20];
            double[] b = new double[30];
            double[] c = new double[50];

            for (x=0; x<20; x++)
            {
                Console.WriteLine("Digite o {0}º valor de A: ", x + 1);
                a[x] = double.Parse(Console.ReadLine());
            }
            for (x=0; x<30; x++)
            {
                Console.WriteLine("Digite o {0}º valor de B: ", x + 1);
                b[x] = double.Parse(Console.ReadLine());
            }
            for (x = 0; x < 20; x++)
            {
                c[x] = a[x];
            }
            for (x=0; x < 20; x++)
            {
                Console.WriteLine("O {0}º valor de c é {1}",x+1, c[x]);
            }
            for (x=20; x<50; x++)
            {
                c[x] = b[x - 20];
            }
            for (x=20; x<50; x++)
            {
                Console.WriteLine("O {0}º valor de c é {1}", x + 1, b[x - 20]);
            }
            Console.ReadKey();
        }
    }
}
