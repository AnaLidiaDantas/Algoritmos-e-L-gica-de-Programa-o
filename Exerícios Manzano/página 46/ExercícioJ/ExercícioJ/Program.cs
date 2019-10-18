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
            int cont = 50, soma=0;
            int m=1;

            while ((cont >= 50) && (cont <= 70))
            {
                if (cont % 2 == 0)
                {
                    soma = cont + soma;
                    m =cont/11;
                }
                cont++;
            }
            Console.WriteLine("soma = {0}", soma);
            Console.WriteLine("média = {0}", m);
            Console.ReadKey();
        }
    }
}
