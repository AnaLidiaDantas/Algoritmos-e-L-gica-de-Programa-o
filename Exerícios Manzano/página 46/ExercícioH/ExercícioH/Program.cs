using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioH
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 10, f;

            while (cont <= 100)
            {
                f = (9 * cont + 160) / 5;
                Console.WriteLine("{0}", f);
                cont = cont + 10;
            }
            Console.ReadKey();
        }
    }
}
