using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione C para Continue");
                Console.WriteLine("Pressione B para Break");
                string tecla = Console.ReadKey(true).KeyChar.ToString();

                if(tecla == "c")
                {
                    Console.WriteLine("Continue");
                    continue;
                }
                else if(tecla == "b") 
                {
                    Console.WriteLine("Break");
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida!");
                }

                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();

            }

        }
    }
}
