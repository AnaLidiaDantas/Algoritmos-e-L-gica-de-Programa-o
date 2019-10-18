using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7J
{
    class Program
    {
        static void Main(string[] args)
        {
            float Cotacao, Dolares, Reais;

            Console.Write("Digite a cotação atual do dólar: R$ ");
            Cotacao = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor em dólares que deseja converter: $ ");
            Dolares = float.Parse(Console.ReadLine());

            Reais = Dolares * Cotacao;

            Console.Write("O valor convertido para reais é de R${0:#.#,#}",Reais);
            Console.ReadKey();
        }
    }
}
