using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*escrevendo linha a linha*/
            Console.WriteLine("Oi C#!");
            Console.WriteLine("Tudo bem com você?");          

            /*imprimir palavra por palavra*/
            Console.Write("Meu nome ");
            Console.Write("é ");
            Console.Write("Bruno Gabriel");

            Console.Write("\r\n");

            /*pula linha*/
            Console.Write("Meu nome ");
            Console.Write("é ");
            Console.Write("\r\n");
            Console.Write("Bruno Gabriel");

            Console.Write("\r\n");

            /*Esta função espera a leitura do teclado
              desta forma, o console fica aberto, permitindo 
              a leitura das mensagens*/
            Console.ReadKey();

        }
    }
}
