using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Digite o peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            if (imc < 19)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else
            {
                if (imc < 24)
                {
                    Console.WriteLine("Peso normal");
                }
                else
                {
                    if (imc < 27)
                    {
                        Console.WriteLine("Acima do peso");
                    }
                    else
                    {
                        Console.WriteLine("Obesidade");
                    }
                }
            }
            Console.WriteLine("IMC: {0}", imc);
            Console.ReadKey();


        }
    } 

}
