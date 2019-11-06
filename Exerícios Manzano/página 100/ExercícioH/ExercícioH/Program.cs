using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioH
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[10, 7];
            int i, j, cont=0;
            double par=0, impar=0, percent_par, percent_impar;

            for (i=0; i<10; i++)
            {
                for (j=0; j<7; j++)
                {
                    Console.Write("Digite A[{0}-{1}]: ", i + 1, j + 1);
                    a[i, j] = double.Parse(Console.ReadLine());
                    cont = cont + 1;
                }
            }

            for (i=0 ; i<10; i++)
            {
                for (j=0; j<7; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        par = par + 1;
                    }
                    else
                    {
                        impar = impar + 1;
                    }
                }
            }

            percent_par = par / cont * 100;
            percent_impar = impar / cont * 100;
            Console.WriteLine("A matriz possui {0} elementos pares e {1} elementos ímpares.", par, impar);
            Console.WriteLine("{0}% de elementos pares e {1}% de elementos ímpares.", percent_par, percent_impar);
            Console.ReadKey();
        }
    }
}
