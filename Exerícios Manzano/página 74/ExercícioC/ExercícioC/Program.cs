using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioC
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            double[] a = new double[20];
            double[] b = new double[20];
            double[] c = new double[20];

            for (y=0; y<20; y++)
            {
                Console.WriteLine("Digite o {0}º número inteiro para A: ", y+1);
                a[y] = double.Parse(Console.ReadLine());                
            }
            for (y = 0; y < 20; y++)
            {
                 Console.WriteLine("Digite o {0}º número inteiro para B: ", y+1);
                 b[y] = double.Parse(Console.ReadLine());
            }
            for(y=0; y < 20; y++)
            {
                c[y] = a[y] - b[y];
                Console.WriteLine("{0}-{1}={2}", a[y], b[y], c[y]);
            }
            Console.ReadKey();
        }
    }
}
