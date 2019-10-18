using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, j=0, x;
            double[] a = new double[6];
            double[] b = new double[6];
            double[] c = new double[12];
            
            while ((i < 6) || (j < 6))
           {
                Console.Write("Digite um valor:");

                x = int.Parse(Console.ReadLine());

                if ((x % 2 == 0) && (i < 6))
                {
                    a[i] = x;
                    c[i] = a[i];
                    i++;
                }
                if ((x % 2!=0)&& (j < 6)){
                     b[j] = x;
                     c[j + 6] = b[j];
                     j++;
                }
            }
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("C[{0}]={1}", i + 1, c[i]);
            }
                
            Console.ReadKey();
        }
    }
}
