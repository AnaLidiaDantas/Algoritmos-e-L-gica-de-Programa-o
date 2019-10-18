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
            double q;
            int cont = 15;

            do
            {
                q = Math.Pow(cont, 2);
                Console.WriteLine("{0}²={1}", cont, q);
                cont++;
            } while (cont <= 200);
            Console.ReadKey();
        }
    }
}
