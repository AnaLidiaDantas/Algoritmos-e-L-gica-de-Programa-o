using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, m;

            Console.Write("Digite a tabuada desejada: ");
            a = int.Parse(Console.ReadLine());

            for (b=1; b<=10; b++)
            {
                m = b * a;
                Console.WriteLine("{0}X{1}={2}", a, b, m);
              }
            Console.ReadKey();
        }
    }
}
