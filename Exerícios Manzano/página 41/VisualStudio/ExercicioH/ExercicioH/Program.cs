using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioH
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;

            Console.Write("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de d: ");
            d = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de e: ");
            e = int.Parse(Console.ReadLine());

            if((a>b)&& (a > c) && (a > d) && (a > e))
            {
                Console.WriteLine("O maior valor é {0}", a);
            }
            else
            {
                if ((b > a) && (b > c) && (b > d) && (b > e))
                {
                    Console.WriteLine("O maior valor é {0}", b);
                }
                else
                {
                    if ((c > a) && (c > b) && (c > d) && (c > e))
                    {
                        Console.WriteLine("O maior valor é {0}", c);

                    }
                    else
                    {
                        if ((d > a) && (d > b) && (d > c) && (d > e))
                        {
                            Console.WriteLine("O maior valor é {0}", d);
                        }
                        else
                        {
                            Console.WriteLine("O maior valor é {0}", e);
                        }
                    }
                }

            }
            if ((a < b) && (a < c) && (a < d) && (a < e))
            {
                Console.WriteLine("O menor valor é {0}", a);
            }
            else
            {
                if ((b < a) && (b < c) && (b < c) && (b < d) && (b < e))
                {
                    Console.WriteLine("O menor valor é {0}", b);
                }
                else
                {
                    if ((c < a) && (c < b) && (c < d) && (c < e))
                    {
                        Console.WriteLine("O menor valor é {0}", c);
                    }
                    else
                    {
                        if ((d < a) && (d < b) && (d < c) && (d < e))
                        {
                            Console.WriteLine("O menor valor é {0}", d);
                        }
                        else
                        {
                            Console.WriteLine("O menor valor é {0}", e);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
