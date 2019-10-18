using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioG
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            for (double g=0; g <= 15; g++)
            {
                p=Math.Pow(g, 3);
                Console.WriteLine("{0}³={1}", g, p);
            }
            Console.ReadKey();
        }
    }
}
