using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioA
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            //int i;

            for (int i = 15; i <= 200; i++)
            {
                a = Math.Pow(i, 2);
                Console.Write("{0}, ", a);
            }
            Console.ReadKey();
        }
    }
}
