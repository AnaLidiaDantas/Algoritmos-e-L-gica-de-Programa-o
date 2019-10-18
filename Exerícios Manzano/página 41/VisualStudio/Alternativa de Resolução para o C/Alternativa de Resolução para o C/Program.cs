using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternativa_de_Resolução_para_o_C
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;

            Console.Write("N1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("N2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("N3: ");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("N4: ");
            n4 = float.Parse(Console.ReadLine());


            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 5)
            {
                Console.WriteLine("Aluno Aprovado");
                Console.WriteLine("Média do aluno: {0}", media);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
                Console.WriteLine("Média do aluno: {0}", media);
            }
            Console.ReadKey();
        }
    }
}
