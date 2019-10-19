using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m=0, p=0, o=0, j=0;
            double[] n = new double[10];
            double[] impar = new double[10];
            double[] par = new double[10];

            for (i=0; i<10; i++)
            {
                Console.Write("Digite o {0}º valor: ",i+1) ;
                n[i] = double.Parse(Console.ReadLine());
            }

            for (i=0; i<10; i++)
            {
                Console.WriteLine("O {0}º valor digitado foi: {1}", i + 1, n[i]);
            }

            for (i = 0; i < 10; i++) 
            {
                if (n[i] % 2 == 0)
                {
                    par[m] = n[i];
                    o = m;
                    m = m + 1;
                }
                else
                {
                    impar[p] = n[i];
                    j = p;
                    p = p + 1;
                }
            }
            for(m=0; m <= 0; m++)
            {
                Console.WriteLine("{0} é par.", par[m]);
            }
            for (p = 0; p <= j; p++)
            {
                Console.WriteLine("{0} é impar.", impar[p]);
            }
            Console.ReadKey();
        }
    }
}
