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
            int cont = 1, soma = 0 ;

            do
            {
                if (cont % 2 == 0)
                {
                    soma = soma + cont;  
                }
                cont++;
            } 
           
            while (cont <= 500);
            Console.Write("{0} ", soma);
            Console.ReadKey();
        }
    }
}
