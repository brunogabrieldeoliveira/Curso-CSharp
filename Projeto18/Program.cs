using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*VARIÁVEIS*/
            string nome, nomeDaRua;
            DateTime dataNascimento;
            char genero;
            int numeroDaCasa;

            while (true)
            {
                Console.WriteLine("Digite S para sair ou C para cadastrar:");
                char opcao = char.ToLower(Convert.ToChar(Console.ReadKey(true).KeyChar));

                if (opcao == 's')
                {
                    break;
                }
                else if (opcao == 'c')
                {
                    /*COLETANDO AS INFORMAÇÕES*/

                    Console.WriteLine("Digite o seu nome completo: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Informe o seu genero, M masculino e F feminino: ");
                    genero = Convert.ToChar(Console.ReadKey(true).KeyChar);
                    Console.WriteLine("Digite a sua data de nascimento no formato dd/mm/aaaa: ");
                    dataNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome da sua rua: ");
                    nomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite o número da sua casa: ");
                    numeroDaCasa = Convert.ToInt32(Console.ReadLine());

                    /*EXIBINDO OS DADOS*/
                    Console.WriteLine(nome);
                    Console.WriteLine(genero);
                    Console.WriteLine(dataNascimento);
                    Console.WriteLine(nomeDaRua);
                    Console.WriteLine(numeroDaCasa);

                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Opção inválida!");

                    Console.WriteLine("Pressione qualquer tecla continuar...");
                    Console.ReadKey();
                }                

            }

            Console.WriteLine("Pressione qualquer tecla para sair ...");
            Console.ReadKey();

        }
    }
}
