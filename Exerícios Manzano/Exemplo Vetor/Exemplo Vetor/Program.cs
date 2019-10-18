using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, soma = 0;
            int i;
            double[] md = new double[8];

            for (i=0; i<=7; i++)
            {
                Console.WriteLine("Digite a {0}ª nota: ", i + 1);
                md[i] = double.Parse(Console.ReadLine());
                soma = soma + md[i];
            }
            for(i=0; i <= 7; i++)
            {
                Console.WriteLine("A {0}ª nota: {1}", i + 1, md[i]);
            }
            media = soma / 8;
            Console.Write("A média é: {0}", media);
            Console.ReadKey();
        }
    }
}
