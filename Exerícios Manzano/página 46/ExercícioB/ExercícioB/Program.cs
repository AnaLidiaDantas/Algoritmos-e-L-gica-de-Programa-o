using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, aux, cont=1; //não precisaria da variável 'aux'
            aux = 0;            //não precisaria desta linha
            while (cont <= 100)
            {
                a = aux + cont;//alternativa de solução: a=cont+a;
                aux = a;        //não necessitaria desta linha
                cont++;
            }
           Console.Write("A soma total é {0}", aux);
            Console.ReadKey();


        }
    }
}
