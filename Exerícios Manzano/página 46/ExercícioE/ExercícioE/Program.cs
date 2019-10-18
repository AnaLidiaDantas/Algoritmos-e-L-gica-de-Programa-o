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
            int exp = 0;
            double pot;

            while (exp <= 15)
            {
                //pot = exp * exp * exp;
                pot = Math.Pow(exp, 3);
                Console.WriteLine("{0}³={1}", exp, pot);
                exp++;
            }
            Console.ReadKey();
        }
    }
}
