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
            int a;

            Console.Write("Digite um número de 1 a 9: ");
            a = int.Parse(Console.ReadLine());

            if ((a >= 1) && (a <= 9))
            {
                Console.Write("O valor está na faixa permitida");
            }
            else
            {
                Console.Write("O valor está fora da faixa permitida");
            }
            Console.ReadKey();
        }
    }
}
