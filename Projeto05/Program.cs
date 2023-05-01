using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*variáveis*/
            int Idade = 18;
            Console.WriteLine(Idade);

            string nomeCompleto = "Bruno Gabriel";
            Console.WriteLine(nomeCompleto);

            //byte b = 10000; O valor é muito grande para uma variável do tipo byte

            var salario = 10000;
            var nomeDaMae = "Joana";
            //nomeDaMae = 100000 - Não é possível, pois o compilador ja definiu que o tipo da variável será string

            Console.WriteLine(salario);
            Console.WriteLine(nomeDaMae);

            DateTime dataNascimento = new DateTime(1994, 7, 10, 10, 30, 22);
            Console.WriteLine(dataNascimento);
            Console.WriteLine("Data " + dataNascimento.Year);
            Console.WriteLine("Mês " + dataNascimento.Month);
            Console.WriteLine("Dia " + dataNascimento.Day);
            Console.WriteLine("Ano " + dataNascimento.Hour);
            Console.WriteLine("Minutos " + dataNascimento.Minute);
            Console.WriteLine("Segundos " + dataNascimento.Second);



            /*CONVERTENDO VARIÁVEIS*/

            /*string para int*/
            string numeroDaCasa = "3129";
            int numeroDaCasaInt = Convert.ToInt32(numeroDaCasa);
            Console.WriteLine("O número da casa é " + numeroDaCasaInt);

            /*int para string*/
            string numeroDaCasaString = Convert.ToString(numeroDaCasaInt);
            Console.WriteLine("O número da casa é " + numeroDaCasaString);


            byte b = 35;
            char c = Convert.ToChar(b); // converte para a tabela ASCII
            Console.WriteLine(c); // assim imprime o caractere # tabela ASCII


            Console.ReadKey();

        }
    }
}
