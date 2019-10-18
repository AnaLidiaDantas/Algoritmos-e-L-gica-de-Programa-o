//Bibliotecas que contem os comandos que serão utilizados
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace <nome do projeto>
namespace Exemplo
{
    class Program

    {
        static void Main(string[] args)

            //Programa Principal
        {
            //float e double são para declarar variáveis reais no C#
            //float é 'menor' e double é 'maior'
            //para declarar variável inteira usar 'int'
            //para declarar variável literal usar  'string'

            float C, F; //declarando variáveis C e F como real

            Console.Write("Digite a temperatura em Graus Celsius: "); //Write é o comando usado para escrever 
            //Para escrever e pular para a próxima linha usar o comando WriteLine
            C = float.Parse(Console.ReadLine()); //Como estamos usando o console e o console entende tudo como caracteres,
            //precisamos converter para 'float'
            //C = real.converter(Console.LeiaLinha());


            F = (9 * C + 160) / 5;

            Console.Write("{0} Graus Celsius convertidos para Fahrenheit é {1} ",C,F);//{0} é usado quando eu quero que a variável seja exibida. Se inicia em zero e vai aumentando
                                                                                  //de um em um de acordo com o nº de variáveis do programa
            Console.ReadKey(); //Para que o resultado não suma da tela nós acrescentamos um comando que fica aguardando que seja apertada uma tecla antes de executar a próxima ação

        }
    }
}
