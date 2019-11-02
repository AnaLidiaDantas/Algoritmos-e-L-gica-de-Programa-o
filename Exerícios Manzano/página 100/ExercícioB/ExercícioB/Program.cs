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
            int[]a = new int[7];
            int[]b = new int[7];
            int[,] c = new int[7, 2];
            int i, j;

            //Inserindo valores de A
            for (i = 0; i < 7; i++)
            {
                Console.Write("Digite A[{0}]: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            //Inserindo valores de B
            for (i = 0; i < 7; i++)
            {
                Console.Write("Digite B[{0}]: ", i + 1);
                b[i] = int.Parse(Console.ReadLine());
            }

            //Matriz C
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    c[i, j] = a[i];
                }
                for (j = 1; j < 2; j++)
                {
                    c[i, j] = b[i];
                }
            }
            Console.WriteLine("--------Matriz C-------------");
            for (i = 0; i < 7; i++)
            {
                for (j=0; j < 2; j++)
                {
                    Console.WriteLine("C[{0}-{1}] = {2}", i + 1, j + 1, c[i, j]);
                }
            }
            Console.ReadKey();
            
        }
    }
}
