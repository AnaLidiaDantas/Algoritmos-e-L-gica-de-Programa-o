using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[8, 5];
            int i, j;

            for (i=0; i < 8; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("Digite a nota {0} - {1}: ", i+1, j+1);
                    notas[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Nota[{0},{1}] = {2}", i+1, j+1, notas[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
