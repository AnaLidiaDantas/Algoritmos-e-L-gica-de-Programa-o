using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Digite o número de alunos: ");
            x = int.Parse(Console.ReadLine());

            double[] g1 = new double[x];
            double[] g2 = new double[x];
            double[] media = new double[x];

            for (y = 0; y < x; y++)
            {
                Console.Write("Digite a nota G1 do {0}º aluno: ", y + 1);
                g1[y] = double.Parse(Console.ReadLine());
            }
            for (y=0; y<x; y++)
            {
                Console.Write("Digite a nota G2 do {0}º aluno: ", y + 1);
                g2[y] = double.Parse(Console.ReadLine());
            }
            for (y=0; y<x; y++)
            {
                media[y] = (g1[y] + g2[y]) / x;
                Console.WriteLine("Aluno {0} --> G1 = {1} - - G2 = {2} - - Média = {3}", y + 1, g1[y], g2[y], media[y]);
            }
            Console.ReadKey();

        }
    }
}
