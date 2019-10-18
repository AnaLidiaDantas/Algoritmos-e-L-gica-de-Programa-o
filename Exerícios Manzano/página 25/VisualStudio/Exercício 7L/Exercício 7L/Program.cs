using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7L
{
    class Program
    {
        static void Main(string[] args)
        { double A, B, C, D;
Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine());

            //Processamento
            D = Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2);

            Console.Write("A soma dos quadrados é: {0}", D);
            Console.ReadKey();


        }
    }
}
