using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto32
{
    internal class Program
    {
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagDataNascimento;
        static string tagNomeDaRua;
        static string tagNumeroDaCasa;

        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNascimento;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
        }

        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2
        }

        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
            {
                retorno = Resultado_e.Sair;
            }
            else
            {
                minhaString = temp;
                retorno = Resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exceção: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;

                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;

        }
        public static Resultado_e PegaUInt32(ref UInt32 numeroUInt32, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        numeroUInt32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exceção: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;

                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;

        }

        public static Resultado_e CadastraUsuario(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuarios;
            cadastroUsuarios.Nome = "";
            cadastroUsuarios.DataDeNascimento = new DateTime();
            cadastroUsuarios.NomeDaRua = "";
            cadastroUsuarios.NumeroDaCasa = 0;

            //salvado os dados na estrutura de dados
            if (PegaString(ref cadastroUsuarios.Nome, "Digite o nome completo ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaData(ref cadastroUsuarios.DataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref cadastroUsuarios.NomeDaRua, "Digite o nome da rua ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaUInt32(ref cadastroUsuarios.NumeroDaCasa, "Digite o numero da casa ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;

            ListaDeUsuarios.Add(cadastroUsuarios);
            return Resultado_e.Sucesso;
        }

        public static void GravaDados(string caminho, List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            try
            {
                string conteudoArquivo = "";
                foreach (DadosCadastraisStruct cadastro in ListaDeUsuarios)
                {
                    conteudoArquivo += delimitadorInicio + "\n\r";
                    conteudoArquivo += tagNome + cadastro.Nome + "\n\r";
                    conteudoArquivo += tagDataNascimento + cadastro.DataDeNascimento.ToString("dd/MM/yyyy") + "\n\r";
                    conteudoArquivo += tagNomeDaRua + cadastro.NomeDaRua + "\n\r";
                    conteudoArquivo += tagNumeroDaCasa + cadastro.NumeroDaCasa + "\n\r";
                    conteudoArquivo += delimitadorFim + "\n\r";
                
                }
                File.WriteAllText(caminho, conteudoArquivo);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
        }

        public static void CarregaDados(string caminho, ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {

            try
            {
                string[] conteudoArquivo = File.ReadAllLines(caminho);
                DadosCadastraisStruct dadosCadastrais;
                dadosCadastrais.Nome = "";
                dadosCadastrais.DataDeNascimento = new DateTime();
                dadosCadastrais.NomeDaRua = "";
                dadosCadastrais.NumeroDaCasa = 0;

                foreach(string linha in conteudoArquivo)
                {
                    if (linha.Contains(delimitadorInicio))
                        continue;
                    if (linha.Contains(delimitadorFim))
                        ListaDeUsuarios.Add(dadosCadastrais);
                    if (linha.Contains(tagNome))
                        dadosCadastrais.Nome = linha.Replace(tagNome, "");
                    if (linha.Contains(tagDataNascimento))
                        dadosCadastrais.DataDeNascimento = Convert.ToDateTime(linha.Replace(tagDataNascimento, ""));
                    if (linha.Contains(tagNomeDaRua))
                        dadosCadastrais.NomeDaRua = linha.Replace(tagNomeDaRua, "");
                    if (linha.Contains(tagNumeroDaCasa))
                        dadosCadastrais.NumeroDaCasa = Convert.ToUInt32(linha.Replace(tagNumeroDaCasa, ""));

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }


        }

        static void Main(string[] args)
        {
            //Cria a lista de usuários cadastrados
            List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";

            delimitadorInicio = "#### INICIO ####"; 
            delimitadorFim = "#### FIM ####";
            tagNome = "NOME: ";
            tagDataNascimento = "DATA_DE_NASCIMENTO: ";
            tagNomeDaRua = "NOME_DA_RUA: ";
            tagNumeroDaCasa = "NUMERO_DA_CASA: ";
            
            string caminhoArquivo =  @"C:\temp\C#\Projeto32\baseDeDados.txt";

            CarregaDados(caminhoArquivo, ref ListaDeUsuarios);

            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair...");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if (opcao == "c")
                {
                    if (CadastraUsuario(ref ListaDeUsuarios) == Resultado_e.Sucesso)
                        GravaDados(caminhoArquivo, ListaDeUsuarios);
                }
                else if (opcao == "s")
                {
                    MostraMensagem("Encerrando o programa!");
                }
                else
                {
                    MostraMensagem("Opção desconhecida!");
                }

            } while (opcao != "s");

        }
    }
}
