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
            int[,] a = new int[4, 5];
            int i, j;

            for (i = 0; i < 4; i++)
            {
                for (j=0; j<5; j++)
                {
                    Console.Write("Digite A[{0}-{1}]: ", i + 1, j + 1);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i=0; i<4; i++)
            {
                for (j=0; j<5; j++)
                {
                    Console.WriteLine("A[{0}-{1}] = {2}", i + 1, j + 1, a[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
