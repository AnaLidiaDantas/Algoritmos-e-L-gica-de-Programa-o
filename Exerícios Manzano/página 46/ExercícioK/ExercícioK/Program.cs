using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioK
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, resp="sim";
            float area_comodo, comprimento, largura;
            float area_total = 0;
            

            while (resp == "sim")
            {
            Console.Write("Digite o nome do cômodo que deseja calcular: ");
            nome = Console.ReadLine();
            Console.Write("Digite a largura do {0}: ", nome);
            largura = float.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do {0}: ", nome);
            comprimento = float.Parse(Console.ReadLine());

            area_comodo = largura * comprimento;
            Console.WriteLine("Área do {0}: {1}m²",nome, area_comodo);
            area_total = area_comodo + area_total;
            Console.Write("Deseja calcular outro cômodo?");
            resp = Console.ReadLine();
            }
            Console.WriteLine("Área total: {0}m²", area_total);
            Console.ReadKey();
        }
    }
}
