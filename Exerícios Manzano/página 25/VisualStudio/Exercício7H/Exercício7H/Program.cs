using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7H
{
    class Program
    {
        static void Main(string[] args)
        {
            float Volume, Comprimento, Altura, Largura;

            Console.Write("Digite o valor do Comprimento: ");
            Comprimento = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor da largura: ");
            Largura = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor da Altura: ");
            Altura = float.Parse(Console.ReadLine());

            //Processamento
            Volume = Comprimento * Altura * Largura;

           Console.Write("O volume do retangulo e: {0}", Volume);
            Console.ReadKey();

        }
    }
}
