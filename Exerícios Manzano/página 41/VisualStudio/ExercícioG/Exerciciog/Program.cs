using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciog
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.Write("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de d: ");
            d = int.Parse(Console.ReadLine());

            if ((a % 2 == 0)&& (a % 3 == 0))
            {
                Console.WriteLine("{0} é divisível por 2 e 3.", a);
           
      
            }
            else
            {
                Console.WriteLine("{0} não é Divisível por 2 e 3.",a);
            
            }
            if ((b % 2 == 0)&& (b % 3 == 0))
            {
                Console.WriteLine("{0} é divisível por 2 e 3.", b);

            }
            else
            {
                Console.WriteLine("{0} não é Divsível por 2 e 3", b);

            }
            if ((c % 2 == 0) && (c % 3 == 0))
            {
                Console.WriteLine("{0 é divisível por 2 e 3.}", c);
            }
            else
            {
                Console.WriteLine("{0} não é Divisível por 2 e 3", c);

            }
            if ((d % 2 == 0)&& (d % 3 == 0) )
            {
                Console.WriteLine("{0 é divisível por 2 e 3.}", d);

            }
            else
            {
                Console.WriteLine("{0} não é Divisível por 2 e 3", d);

            }
            

            Console.ReadKey();
                
            
        }
    }
}
