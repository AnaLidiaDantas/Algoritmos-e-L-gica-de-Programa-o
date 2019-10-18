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
            int i;
            double[] m = new double[10];

            for (i=0; i<10; i++)
            {
                Console.Write("Digite o {0}º número: ",i+1);
                m[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("O {0}º número é {1}", i + 1, m[i]);
            }
            
            Console.ReadKey();
        }
    }
}
