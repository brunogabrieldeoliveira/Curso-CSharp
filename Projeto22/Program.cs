using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto22
{
    /*STRUCT*/
    struct dadosCadastrais
    {
        public string nome;
        public string nomeDaRua;
        public UInt32 numeroDaCasa;
        public string numeroDoDocumento;

    };

    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando a lista de cadastros
            List<dadosCadastrais> listaDeCadastros = new List<dadosCadastrais>();

            string opcao;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if (opcao == "s")
                {
                    Console.WriteLine("Encerrando a aplicação!");
                }
                else if (opcao == "c")
                {
                    /*COLETANDO OS DADOS*/

                    dadosCadastrais dadosCadastrais;

                    Console.WriteLine("Digite seu nome: ");
                    dadosCadastrais.nome = Console.ReadLine();

                    Console.WriteLine("Digite o nome da sua rua: ");
                    dadosCadastrais.nomeDaRua = Console.ReadLine();

                    Console.WriteLine("Digite o numero da sua casa: ");
                    dadosCadastrais.numeroDaCasa = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Digite o numero do seu documento: ");
                    dadosCadastrais.numeroDoDocumento = Console.ReadLine();

                    /*GRAVANDO OS DADOS*/
                    listaDeCadastros.Add(dadosCadastrais);
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    continue;
                }
            } while (opcao != "s");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();


        }
    }
}
