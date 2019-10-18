using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite um número inteiro: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            c = int.Parse(Console.ReadLine());
            //a b c ou a c b ou b a c ou b c a ou c a b ou c b a
            i   if ((c > b) && (b > a))
                {
                    Console.Write("{0}, {1}, {2}", a, b, c);
                }
            else
            {
                if ((b > c) && (c > a))
                {
                    Console.Write("{0}, {1}, {2}", a, c, b);
                }
                else
                {
                    if ((b > a) && (a > c))
                    {
                        Console.Write("{0}, {1}, {2}"b, a, c);
                    }
                    else
                }
            }
            }
        }
    
}
