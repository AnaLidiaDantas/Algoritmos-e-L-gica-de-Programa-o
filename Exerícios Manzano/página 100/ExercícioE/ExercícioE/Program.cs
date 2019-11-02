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
            double[,] a = new double[10, 10];
            int i, j;
            double soma=0;

            for (i=0; i<10; i++)
            {
                for (j=0; j < 10; j++)
                {
                    Console.Write("Digite A[{0}-{1}]: ", i + 1, j + 1);
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (i=0; i<10; i++)
            {
                for (j=0; j<10; j++)
                {
                    if (i == j)
                    {
                        soma = soma + a[i, j];
                    }
                }
            }
            Console.Write("Soma = {0}", soma);
            Console.ReadKey();
        }
    }
}
