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
            double[] a = new double[15];
            double[] b = new double[15];
            int i, j;
            double x;

            //Ler valores de A
            for (i=0; i < 15; i++)
            {
                Console.Write("Digite o {0}º valor de A: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }

            //definindo valores de B
            for (i=0; i<15; i++)
            {
                b[i] = a[i] / 2;
            }

            //Ordenação de A
            for (i = 0; i < 15; i++)
            {
                for (j = 14 - i; j < 15; j++)
                {
                    if (a[i] > a[j])
                    {
                        x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }
            
            //Ordenação de B
            for (i=0; i<15; i++)
            {
                for (j=i+1;j<15; j++)
                {
                    if (b[i] > b[j])
                    {
                        x = b[i];
                        b[i] = b[j];
                        b[j] = x;
                    }
                }
            }

            //Mostrar A
            for (i=0; i<15; i++)
            {
                Console.WriteLine("O {0}º valor de A é {1}.", 15 - i, a[i]);
            }

             //Mostrar B
             for (i=0; i < 15; i++)
            {
                Console.WriteLine("O {0}º valor de B é {1}.", i + 1, b[i]);
            }

            Console.ReadKey();
        }
    }
}
