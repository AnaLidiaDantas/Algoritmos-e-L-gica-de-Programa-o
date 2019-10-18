using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioK
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat, n, cont;
            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            cont = n;

            for(int k=1; k<=10; k++)
            {
                if (k % 2 == 1)
                {
                    for (fat =k; fat>=1 ; fat--)
                    {
                        fat = fat * k;
                        Console.WriteLine("{0}", fat);

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
