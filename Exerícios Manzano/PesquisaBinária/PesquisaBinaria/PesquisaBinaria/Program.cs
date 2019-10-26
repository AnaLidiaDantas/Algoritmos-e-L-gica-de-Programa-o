using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i, j, comeco, meio=0, final, x, pesq;
            string resp = "sim";
            bool acha;

            for(i=0; i <= 9; i++)
            {
                Console.WriteLine("Digite um número: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //Ordenação
            for (i = 0; i <=10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (num[i] > num[j])
                    {
                        x = num[i];
                        num[i] = num[j];
                        num[j] = x;
                    }
                }
            }

            /*Mostrar
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine("Número {0} = {1}", i + 1, num[i]);
            }*/

            //Pesquisa
            while (resp == "sim")
            {
                Console.Write("Digite o número que deseja pesquisar? ");
                pesq=int.Parse(Console.ReadLine());
                comeco = 0;
                final = 9;
                acha = false;

                while ((comeco <= final) && (acha == false))
                {
                    meio = (comeco + final) / 2;
                    if (pesq == num[meio])
                    {
                        acha = true;
                    }
                    else
                    {
                        if (pesq < num[meio])
                        {
                            final = meio - 1;
                        }
                        else
                        {
                            comeco = meio + 1;
                        }
                    }
                }
                    if (acha == true)
                    {
                        Console.WriteLine("{0} - Foi encontrado na posição {1}.", pesq, meio+1);
                    }
                    else
                    {
                        Console.WriteLine("{0} - Não foi localizado!!!", pesq);
                    }
                    Console.WriteLine("Deseja continuar? [sim/nao] ");
                    resp = Console.ReadLine();
               }
            Console.ReadKey();

        }
    }
}
