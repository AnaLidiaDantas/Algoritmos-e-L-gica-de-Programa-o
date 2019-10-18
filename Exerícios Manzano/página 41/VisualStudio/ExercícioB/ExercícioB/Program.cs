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
            int A;

            Console.Write("Digite um número inteiro: ");
            A = int.Parse(Console.ReadLine());
            if (A < 0)
            {
                A = A * (-1);
                Console.Write("O módulo do número digitado é: {0}",A);
                    }
            Console.ReadKey();
        }
    }
}
