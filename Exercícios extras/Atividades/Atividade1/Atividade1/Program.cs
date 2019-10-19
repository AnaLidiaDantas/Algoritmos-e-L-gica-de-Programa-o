using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double[] salario = new double[10];
            double maior=0;

            for (x=0; x < 10; x++)
            {
                Console.Write("Digite um número: ");
                salario[x] = double.Parse(Console.ReadLine());
            }
            for (x = 0; x < 10; x++)
            {
                if (salario[x] > maior)
                {
                    maior = salario[x];
                }
                            }
            Console.Write("O maior salário é {0}", maior);
            Console.ReadKey();
        }
    }
}
