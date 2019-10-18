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
            for(int e=1; e<=20; e++)
            {
                if (e % 2 == 1)
                {
                    Console.WriteLine("{0}", e);
                }
            }
            Console.ReadKey();
        }
    }
}
