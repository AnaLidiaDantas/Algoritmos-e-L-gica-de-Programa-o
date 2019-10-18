using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioE
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;
            
            Console.Write("A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("C: ");
            c = double.Parse(Console.ReadLine());

            delta = (Math.Pow(b,2)) - (4 * a * c);

            if (delta < 0)
            {
                Console.Write("Não existem soluções reais.");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1: {0}", x1);
                Console.WriteLine("X2: {0}", x2);
            }
            Console.ReadKey();
        }
    }
}
