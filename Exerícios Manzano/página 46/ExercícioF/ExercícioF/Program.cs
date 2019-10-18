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
            int b, e;
            double pot;

            Console.Write("Digite o valor da base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do expoente: ");
            e = int.Parse(Console.ReadLine());

            pot = Math.Pow(b, e);
            Console.Write("O valor da potência é {0}", pot);
            Console.ReadKey();
        }
    }
}
