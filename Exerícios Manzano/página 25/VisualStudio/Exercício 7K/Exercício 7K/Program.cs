using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7K
{
    class Program
    {
        static void Main(string[] args)
        {
            float Cotacao, Dolares, Reais;
            Console.Write("Digite o valor em reais que deseja converter: R$ ");
            Reais = float.Parse(Console.ReadLine());
            Console.Write("Digite a cotação atual do dólar: $");
            Cotacao = float.Parse(Console.ReadLine());
           

            Dolares = Reais / Cotacao;

            Console.Write("O valor convertido para dólares é ${0}", Dolares);
            Console.ReadKey();
        }
    }
}
