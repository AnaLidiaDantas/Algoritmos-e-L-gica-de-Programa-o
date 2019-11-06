using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[,] nota = new double[5, 2];
            double[] media = new double[5];
            int i, j;
            /*string aux_nome;
            double aux_nota;*/

            for (i=0; i<5; i++)
            {
                j = 0;
                Console.Write(" Digite o nome do {0}º aluno: ", i + 1);
                nome[i] = Console.ReadLine();
                Console.Write("Digite a 1ª nota do aluno {0}: ", nome[i]);
                nota[i, j] = double.Parse(Console.ReadLine());
                Console.Write("Digite a 2ª nota do aluno {0}: ", nome[i]);
                nota[i, j+1] = double.Parse(Console.ReadLine());

                media[i] = (nota[i, j] + nota[i, j + 1]) / 2;
            }

            
        }
    }
}
