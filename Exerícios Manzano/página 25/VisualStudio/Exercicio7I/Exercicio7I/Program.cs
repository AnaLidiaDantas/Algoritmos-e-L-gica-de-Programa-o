using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7I
{
    class Program
    {
        static void Main(string[] args)
        {double A, B, C, D;

            Console.Write("Digite o valor de A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = float.Parse(Console.ReadLine());

            //Processamento
            //D = (A - B) * (A - B);
                    
            D = Math.Pow((A - B),2);

            Console.Write("O quadrado da diferença de A e B é: {0}", D);
            Console.ReadKey();


               
        }
    }
}
