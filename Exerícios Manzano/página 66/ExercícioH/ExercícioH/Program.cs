using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioH
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, e, resultado=0;

            Console.Write("Digite a base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            e = int.Parse(Console.ReadLine());

            for (float cont=1; cont<=e; cont++)
            {
                if (cont == 1)
                {
                    resultado = b;
                }
                else
                {
                    resultado = resultado * b;
                }
                }
                Console.Write("{0}", resultado);
                Console.ReadKey();
            
        }
    }
}
