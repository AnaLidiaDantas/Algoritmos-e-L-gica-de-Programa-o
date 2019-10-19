using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] salario = new double[5];
            double x = 1000;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o salário da {0}ª pessoa: R$ ", i + 1);
                salario[i] = double.Parse(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                if (salario[i] < x)
                {
                    salario[i] = salario[i] *1.1;
        }
        else{
        salario[i]=salario[i];
            }
}
                for(i=0; i<5;i++)
    {
    Console.WriteLine("{0}º salário atualizado é {1}", i+1, salario[i]);
    }
    Console.ReadKey();
        }
    }
}
