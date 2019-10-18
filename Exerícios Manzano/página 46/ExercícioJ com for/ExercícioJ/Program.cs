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
            double soma=0, media;
            for(int j=50; j<=70; j++)
            {
                if (j % 2 == 0)
                {
                    soma = soma + j;
                }
              }
            media = soma / 11;
            Console.WriteLine("A soma é {0}", soma);
            Console.WriteLine("A média é {0}", media);
            Console.ReadKey();
        }
    }
}
