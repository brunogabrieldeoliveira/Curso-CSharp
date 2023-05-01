using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*variáveis*/
            string nome, documento, nomeDaRua;
            char genero;
            UInt32 numeroDaCasa, idade;

            /*coletando dados*/
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite o número do seu documento: ");
            documento= Console.ReadLine();
            Console.WriteLine("Digite o nome da sua rua: ");
            nomeDaRua = Console.ReadLine();
            Console.WriteLine("Digite o numero da sua casa: ");
            numeroDaCasa= Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Informe seu genero. Pressione F para feminino e M para masculino: ");
            genero= Console.ReadKey(true).KeyChar;

            /*exibindo os dados*/
            Console.WriteLine("Olá " + nome);
            Console.WriteLine("O seu genero é: " + genero);
            Console.WriteLine("Você tem " + idade + " anos de idade.");
            Console.WriteLine("O numero do seu documento é " + documento);
            Console.WriteLine("O nome da sua rua é " + nomeDaRua);
            Console.WriteLine("E o número da sua casa é " + numeroDaCasa);

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();


        }
    }
}
