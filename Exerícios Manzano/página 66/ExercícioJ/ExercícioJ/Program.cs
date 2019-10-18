using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioJ
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            for (double c = 10; c <= 100; c=c+10)
            {
                f = (9 * c + 160) / 5;
                Console.WriteLine("{0}°C = {1}°F", c, f);
            }
            Console.ReadKey();
        }
        
            }
    }
