using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioL
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 1, maior, menor;
            maior = 0;
            menor = 32767;

            while (l >= 0)
            {
                Console.WriteLine("Digite um número inteiro:");
                l = int.Parse(Console.ReadLine());

                if (l > maior)
                {
                    maior = l;
                }
                if ((l < menor) && (l > 0))
                {
                    menor = l;
                }
            }
            Console.WriteLine("O maior valor é: {0}", maior);
            Console.WriteLine("O menor valor é {0}", menor);
            Console.ReadKey();
        }
    }
}
