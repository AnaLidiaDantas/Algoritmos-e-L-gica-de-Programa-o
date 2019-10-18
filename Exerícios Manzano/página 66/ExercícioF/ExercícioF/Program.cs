using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioF
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int f=1; f<=200; f++)
            {
                if (f % 4 == 0)
                {
                    Console.WriteLine("{0}", f);
                }
            }
            Console.ReadKey();
        }
    }
}
