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
            int r = 0;
            for(int d=1; d<=500; d++)
            {
                if (d % 2 == 0)
                {
                    r = r + d;
               
                Console.Write("{0} ", r);
                }
            }
            Console.ReadKey();
        }
    }
}
