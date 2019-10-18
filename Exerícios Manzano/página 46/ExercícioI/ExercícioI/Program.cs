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
            int i=1,v,sv=0;
            double m; ;

            while (i <= 10)
            {
                Console.Write("Digite um número: ");
            v = int.Parse(Console.ReadLine());
                sv = sv + v; ;
                i++;
            }
            m = sv / 10;

            Console.WriteLine("A soma dos números é: {0}", sv);
            Console.WriteLine("A média dos números é: {0}", m);0
            Console.ReadKey();
           
        }
    }
}
