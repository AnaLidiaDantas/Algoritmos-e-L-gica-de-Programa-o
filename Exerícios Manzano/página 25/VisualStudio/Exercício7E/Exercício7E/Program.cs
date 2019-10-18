using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7E
{
    class Program
    {
        static void Main(string[] args)
        {
            float prestacao, valor, taxa, tempo;

            Console.Write("Digite o valor da prestação: ");
            valor = float.Parse(Console.ReadLine());
            Console.Write("Digite o tempo de atraso: ");
            tempo = float.Parse(Console.ReadLine());
            Console.Write("Digite a taxa por atraso: ");
            taxa = float.Parse(Console.ReadLine());

            prestacao =(valor + (valor * taxa / 100) * tempo);

            Console.Write("O valor da prestação com juros é de R${0}", prestacao);
            Console.ReadKey();
        }
    }
}
