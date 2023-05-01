using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione 'A' para alugar um filme ou 'S' para sair da locadora: ");
            char opcao = char.ToLower(Console.ReadKey(true).KeyChar);

            if (opcao == 'a')
            {
                Console.Write("\r\n");
                Console.WriteLine("Pressione 1 para alugar 'Top Gun':");
                Console.WriteLine("Pressione 2 para alugar 'A Bela e a Fera':");
                Console.WriteLine("Pressione 3 para alugar 'Homem aranha':");
                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

                Console.Write("\r\n");
                switch (opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Você alugou 'Top Gun'!");
                        break;

                    case 2:
                        Console.WriteLine("Você alugou 'A Bela e a Fera'!");
                        break;

                    case 3:
                        Console.WriteLine("Você alugou 'Homem aranha'!");
                        break;

                    default:
                        Console.WriteLine("Filme não encontrado!");
                        break;

                }
            }
            else if (opcao == 's')
            {
                Console.WriteLine("Muito Obrigado, volte sempre!");
            }
            else
            {
                Console.WriteLine("Opção desconhecida!");
            }

            Console.Write("\r\n");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
