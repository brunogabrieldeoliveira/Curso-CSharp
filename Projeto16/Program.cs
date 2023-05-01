using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Projeto16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*PROJETO LOGIN CONSOLE*/
            string usuario, senha;

            while (true)
            {
                Console.WriteLine("Digite o nome do seu usuário: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Digite a sua senha: ");
                senha = "";

                while (true)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Enter)
                        break;
                    else
                    {
                        senha += tecla.KeyChar;
                    }
                }

                while (true)
                {
                    if (usuario == "Bruno Gabriel" &&
                        senha == "1234")
                    {
                        Console.WriteLine("Usuário Logado com sucesso!");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Usuário ou senha incorretos!");
                        Console.WriteLine("Digite qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    }
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
