using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7F
{
    class Program
    {
        static void Main(string[] args)
        { float A, B, C;


            Console.Write("Escreva o valor de A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Escreva o valor de B: ");
            B = float.Parse(Console.ReadLine());

            C = B;
            B = A;
            A = C;

            Console.WriteLine("Após trocar os valores de A e B, o valor de A é: {0}", C);
            Console.WriteLine("O valor de B passa a ser de: {0}", B);
            Console.ReadKey();


        }
    }
}
