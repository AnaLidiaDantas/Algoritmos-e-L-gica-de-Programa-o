using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double[] a = new double[15];
            double[] b = new double[15];

            for(x=0; x<15; x++)
            {
                Console.Write("Digite o {0}º valor de A: ", x + 1);
                a[x] = double.Parse(Console.ReadLine());
            }
            for (x=0; x<15; x++)
            {
                if (x % 2 == 0)
                {
                    b[x] = a[x] / 2;
                }
                else
                {
                    b[x]=a[x]*1.5;
                }
                
            }
            for (x=0; x<15; x++)
            {
                Console.WriteLine("A = {0}     B = {1}", a[x], b[x]);
            }
            Console.ReadKey();
        }
    }
}
