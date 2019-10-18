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
            int A;

            Console.Write("Digite um número inteiro: ");
            A = int.Parse(Console.ReadLine());

            if (A % 2 == 0)
            {
                Console.Write("O número é par.");
            }
            else
            {
                Console.Write("O número é ímpar.");
            }
            Console.ReadKey();
        }
    }
}
