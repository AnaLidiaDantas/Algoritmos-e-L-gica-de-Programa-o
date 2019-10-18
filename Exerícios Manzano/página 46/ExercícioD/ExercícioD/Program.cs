using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioD
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            while (cont <= 20)
            {
                if (cont % 2 != 0)
                {
                    Console.WriteLine("{0}", cont);
                }
                cont++;
            }
            Console.ReadKey();
        }
    }
}
