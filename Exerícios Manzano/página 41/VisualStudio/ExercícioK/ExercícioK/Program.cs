using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioK
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Digite um número inteiro: ");
            a = int.Parse(Console.ReadLine());

            if (!(a > 3))
            {
                Console.Write("O valor {0} não é maior que 3", a);
            }
            Console.ReadKey();
        }
    }
}
