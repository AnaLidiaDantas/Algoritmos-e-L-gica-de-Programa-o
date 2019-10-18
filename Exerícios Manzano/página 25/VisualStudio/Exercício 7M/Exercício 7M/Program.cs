using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7M
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D;

            Console.Write("Digite o valor da A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            C = float.Parse(Console.ReadLine());
         
            D = Math.Pow(A+B+C,2);

            Console.Write("O quadrado da soma é {0}", D);
            Console.ReadKey();
                
        }
    }
}
