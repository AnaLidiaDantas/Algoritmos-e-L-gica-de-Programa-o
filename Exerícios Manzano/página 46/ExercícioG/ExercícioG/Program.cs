using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioG
{
    class Program
    {
        static void Main(string[] args)
        {

            int cont = 1, fib, ant = 0, atual = 1;

            while (cont <= 15)
            {
                fib = ant + atual;
                ant = atual;
                atual = fib;
                Console.WriteLine("{0}", atual);
                cont++;
            }

                //Console.Write("{0}", atual);
            
            Console.ReadKey();
        }      
    }
}
