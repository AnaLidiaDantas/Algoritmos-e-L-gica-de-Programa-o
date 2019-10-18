using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioE
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int x;
            double[] a = new double[15];
            double[] b = new double[15];
            double[] c = new double[30];

            for (i=0; i<15; i++)
            {
                Console.Write("Digite o {0}º valor de A: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }
            for(i=0; i<15; i++)
            {
                Console.Write("Digite o {0}º valor de B: ", i + 1);
                b[i] = double.Parse(Console.ReadLine());
            }

            for (x = 0; x < 15; x++)
            {

                c[x] = a[x];

               
            }
            for (x = 0; x < 15; x++)
            {
            Console.WriteLine("O {0}º valor de C é {1}", x + 1, c[x]);
            }
            for (x = 15; x < 30; x++)
            {
                 c[x] = b[x-15];
            }
            for (x = 15; x < 30; x++)
            {
            Console.WriteLine("O {0}º valor de C é {1}", x + 1, c[x]);
            }
                
            
            Console.ReadKey();
        }
    }
}
