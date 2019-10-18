using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioF
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
            
            if ((c > b) && (b > a))
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
                    if ((c > a) && (a > b))
                    {
                        Console.Write("{0}, {1}, {2}", b, a, c);
                    }
                    else
                    {
                        if ((a > c) && (c > b))
                        {
                            Console.Write("{0}, {1}, {2}", b, c, a);
                        }
                        else
                        {
                              if ((b > a) && (a > c))
                                {
                                    Console.Write("{0}, {1}, {2}", c, a, b);
                                }
                            else
                            {
                               // if ((c > b) && (b > a))
                                
                                    Console.Write("{0}, {1}, {2}", c, b, a);
                                
                            }
                            }

                        
                    }
                }
            }
            Console.ReadKey();
        }
    }
}