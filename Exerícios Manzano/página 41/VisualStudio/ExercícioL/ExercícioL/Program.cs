using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioL
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo;

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Sexo: ");
            sexo = Console.ReadLine();

          //  if ((sexo != f) || (sexo != m))
            //{
              //  Console.Write("Sexo inválido");
            //}
            //else
            //{
                if (sexo == "f")
                {
                    Console.WriteLine("Ilma Sra {0}", nome);
                }
                else
                {
                if (sexo=="m")
                    {
                    Console.WriteLine("Ilmo Sr {0}", nome);
                }
                else
                {
                    Console.WriteLine("Sexo inválido");
                }
                }
           // }
            Console.ReadKey();
       
        }     
    }
}
