using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7C
{
    class Program
    {
        static void Main(string[] args)
        {
            double Volume, Altura, Raio;

            Console.Write("Digite o valor do raio: ");
            Raio = double.Parse(Console.ReadLine()) ;
            Console.Write("Digite o valor da altura: ");
            Altura = double.Parse(Console.ReadLine());

            Volume = Math.PI * Math.Pow(Raio, 2) * Altura;


                Console.Write("O volume da lata de óleo é {0:#.#,#}", Volume);// {0:#.#,#} máscara para limitar o número de casas decimais
            Console.ReadKey(); }

    }
}
