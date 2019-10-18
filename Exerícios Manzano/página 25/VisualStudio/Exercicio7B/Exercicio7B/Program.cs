using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {
            //corrigir a programação
            float f, c;

                        Console.Write("Digite a temperatura em graus Fahrenheit: ");
            f = float.Parse(Console.ReadLine());
            c = (f - 32 )* 5 / 9;
            Console.Write("{0} Graus Fahrenheit convertidos para Celsius: {1} ", f, c);
            Console.ReadKey();
        }
    }
}
