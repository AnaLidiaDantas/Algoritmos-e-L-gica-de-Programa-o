using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7G
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, D;
            float S1, S2, S3, S4, S5, S6;
            float M1, M2, M3, M4, M5, M6;

            Console.Write("Insira o valor de A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            C = float.Parse(Console.ReadLine());
            Console.Write("Insira o valor de D: ");
            D = float.Parse(Console.ReadLine());

            //Somas
            S1 = A + B;
            S2 = A + C;
            S3 = A + D;
            S4 = B + C;
            S5 = B + D;
            S6 = C + D;

            Console.WriteLine("Soma1 = {0}", S1);
            Console.WriteLine("Soma2 = {0}", S2);
            Console.WriteLine("Soma3 = {0}", S3);
            Console.WriteLine("Soma4 = {0}", S4);
            Console.WriteLine("Soma5 = {0}", S5);
            Console.WriteLine("Soma6 = {0}", S6);

            //Multiplicações
            M1 = A * B;
            M2 = A * C;
            M3 = A * D;
            M4 = B * C;
            M5 = B * D;
            M6 = C * D;

            Console.WriteLine("Multiplicação1 = {0}", M1);
            Console.WriteLine("Multiplicação2 = {0}", M2);
            Console.WriteLine("Multiplicação3 = {0}", M3);
            Console.WriteLine("Multiplicação4 = {0}", M4);
            Console.WriteLine("Multiplicação5 = {0}", M5);
            Console.WriteLine("Multiplicação6 = {0}", M6);


            Console.ReadKey();

        }
    }
}