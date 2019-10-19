using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] vet1 = new double[5];
            double[] vet2 = new double[5];
            double[] aux = new double[5];

            for (i=0; i<5; i++)
            {
                Console.Write("Digite um número: ");
                vet1[i] = double.Parse(Console.ReadLine());
            }
            for (i=0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                vet2[i] = double.Parse(Console.ReadLine());
            }

            for (i=0; i < 5; i++)
            {
                aux[i] = vet1[i] + vet2[i];
                Console.WriteLine("A soma dos vetores é {0}.", aux[i]);
            
                aux[i] = vet1[i] - vet2[i];
                Console.WriteLine("A diferença dos vetores é {0}.", aux[i]);
                                     
                aux[i] = vet1[i] * vet2[i];
                Console.WriteLine("O produto dos vetores é {0}.", aux[i]);
                     
                aux[i] = vet1[i] / vet2[i];
                Console.WriteLine("A divisão entre os vetores é {0}.", aux[i]);
            }

            Console.ReadKey();


        }
    }
}
