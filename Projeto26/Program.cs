using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projeto26
{
    internal class Program
    {
        //METODOS
        public static double Soma(double a, double b)
        {
            return (a + b);
        }

        public static void Mensagens()
        {
            Console.WriteLine("Mensagem impressa!");
        }

        //Modificadores de parâmetros de entrada
        /*
         * ref - sinaliza que o parâmetro de entrada PODE ser modificado
         * out - sinaliza que o parãmetro de entrada DEVE ser modificado
         */

        public static void Multiplica(double a, double b, ref double resultadoDaOperacao)
        {
            double resultadoDaMultiplicacao = a * b;
            resultadoDaOperacao = resultadoDaMultiplicacao;
        }
        public static void Multiplica2(double a, double b, out double resultadoDaOperacao)
        {
            double resultadoDaMultiplicacao = a * b;
            resultadoDaOperacao = resultadoDaMultiplicacao;
        }

        static void Main(string[] args)
        {
            //chamando método de Soma
            double numero1 = 20.5;
            double numero2 = 20;

            Console.WriteLine("A Soma dos numeros 1 e 2 é: " + Soma(numero1, numero2));
            Console.WriteLine("-----------");

            Mensagens();

            Console.WriteLine("-----------");
            Console.WriteLine("REF");
            double resultadoDaMultiplicacao = 0;
            Multiplica(numero1, numero2, ref resultadoDaMultiplicacao);
            Console.WriteLine("O resultado da multiplicação de " + numero1 + " * " + numero2 + " é: " + resultadoDaMultiplicacao);
            
            Console.WriteLine("-----------");
            Console.WriteLine("OUT");
            resultadoDaMultiplicacao = 0;
            Multiplica2(numero1, numero2, out resultadoDaMultiplicacao);
            Console.WriteLine("O resultado da multiplicação de " + numero1 + " * " + numero2 + " é: " + resultadoDaMultiplicacao);

            Console.ReadKey();



        }
    }
}
