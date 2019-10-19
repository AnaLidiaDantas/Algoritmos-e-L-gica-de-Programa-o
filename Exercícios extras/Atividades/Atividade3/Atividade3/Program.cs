using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double[] a = new double[10];
            double media=0;

            for (x=0; x<10; x++)
            {
                Console.Write("Digite um número: ");
                a[x] = double.Parse(Console.ReadLine());
                media = media + a[x];
            }
           
            media = media / 10;
            Console.Write("A média dos valores é {0}.", media);
            Console.ReadKey();
        }
    }
}
