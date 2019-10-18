using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioI
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int cont=1,fib, ant =0,atual=1; cont <= 15; cont++)
            {
                fib = ant + atual;
                ant = atual;
                atual = fib;
                Console.WriteLine("{0}", atual);
            }
            Console.ReadKey();
        }
    }
}
