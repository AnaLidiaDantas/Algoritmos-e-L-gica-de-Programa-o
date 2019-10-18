using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioC
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            do
            {
                if (cont % 4 == 0)
                {
                    Console.Write("{0} ", cont);
                }
                cont++;
            }
            while (cont <= 200);
            Console.ReadKey();
        }
    }
}
