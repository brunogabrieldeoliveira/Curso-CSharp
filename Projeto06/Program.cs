using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*coleta um dado de entrada*/
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);

            /*coleta um caractere*/
            Console.WriteLine("Pressione qualquer tecla:");
            char teclaPressionada = Console.ReadKey(true).KeyChar;
            Console.WriteLine("A tecla pressionada foi: " + teclaPressionada);

            /*convertendo para string*/
            Console.WriteLine("Pressione qualquer tecla:");
            string teclaPressionadaString = Convert.ToString(Console.ReadKey(true).KeyChar);
            Console.WriteLine("A tecla pressionada foi: " + teclaPressionadaString);

            Console.WriteLine("Pressione qualquer tecla para sair...");


            Console.ReadKey();
        }
    }
}
