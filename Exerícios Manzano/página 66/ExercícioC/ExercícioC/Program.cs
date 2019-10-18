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
            int r = 0;
            for (int b=1;  b <= 100; b++) 
            {
                r = r + b;
                
             }
            Console.Write("{0} ", r);
            Console.ReadKey();
        }
    }
}
