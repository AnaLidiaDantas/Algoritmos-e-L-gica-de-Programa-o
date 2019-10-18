using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7D
{
    class Program
    {
        static void Main(string[] args)
        {
            float Tempo, Velocidade, Distancia, LitrosUsados;

        Console.Write("Digite o tempo gasto: ");
            Tempo= float.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade media: ");
            Velocidade = float.Parse(Console.ReadLine());

            Distancia = Tempo * Velocidade;
            LitrosUsados = Distancia / 12;

            Console.WriteLine("A distância percorrida foi de {0} km.", Distancia);
            Console.WriteLine("A velocidade média foi de {0}km/h.", Velocidade);
            Console.WriteLine("O tempo gasto na viagem foi de {0} horas.", Tempo);
            Console.WriteLine("Foram usados {0} litros na viagem.", LitrosUsados);
            Console.ReadKey();


        }
    }
}
