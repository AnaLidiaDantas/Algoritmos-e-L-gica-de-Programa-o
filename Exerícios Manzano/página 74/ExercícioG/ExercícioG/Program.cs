using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioG
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] a = new double[20];
            double[] b = new double[20];

            for (i=0; i < 20; i++)
            {
                Console.Write("Digite o {0}º valor: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }
            for (i=0; i<20; i++)
            {
                b[i] = a[19-i];
            }
            for (i=0; i < 20; i++)
            {
                Console.WriteLine("O {0}º valor de B é {1}", i + 1, b[i]);
            }
        Console.ReadKey();
        }
    }
}
