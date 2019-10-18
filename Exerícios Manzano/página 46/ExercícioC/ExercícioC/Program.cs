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
            int cont = 1, r=0;
            
            while (cont<=500)
            {
                if (cont % 2 == 0)
                {
                    r = r+cont;
                 }
              cont++;
            }
            Console.Write("{0}", r);
            Console.ReadKey();             
        }
    }
}
