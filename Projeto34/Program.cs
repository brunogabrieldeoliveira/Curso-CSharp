﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto34
{
    internal class Program
    {
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagDataNascimento;
        static string tagNomeDaRua;
        static string tagNumeroDaCasa;
        static string tagNumeroDeDocumento;

        static string caminhoArquivo;

        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNascimento;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
            public string NumeroDoDocumento;
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
            cadastroUsuarios.NumeroDoDocumento = "";

            //salvado os dados na estrutura de dados
            if (PegaString(ref cadastroUsuarios.Nome, "Digite o nome completo ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaData(ref cadastroUsuarios.DataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref cadastroUsuarios.NumeroDoDocumento, "Digite o número do seu documento ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref cadastroUsuarios.NomeDaRua, "Digite o nome da rua ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaUInt32(ref cadastroUsuarios.NumeroDaCasa, "Digite o numero da casa ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;

            ListaDeUsuarios.Add(cadastroUsuarios);
            GravaDados(caminhoArquivo, ListaDeUsuarios);

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
                    conteudoArquivo += tagNumeroDeDocumento + cadastro.NumeroDoDocumento + "\n\r";
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
                DadosCadastraisStruct dadosCadastrais = new DadosCadastraisStruct();
                dadosCadastrais.Nome = "";
                dadosCadastrais.DataDeNascimento = new DateTime();
                dadosCadastrais.NomeDaRua = "";
                dadosCadastrais.NumeroDaCasa = 0;

                foreach (string linha in conteudoArquivo)
                {
                    if (linha.Contains(delimitadorInicio))
                        continue;
                    if (linha.Contains(delimitadorFim))
                        ListaDeUsuarios.Add(dadosCadastrais);
                    if (linha.Contains(tagNome))
                        dadosCadastrais.Nome = linha.Replace(tagNome, "");
                    if (linha.Contains(tagDataNascimento))
                        dadosCadastrais.DataDeNascimento = Convert.ToDateTime(linha.Replace(tagDataNascimento, ""));
                    if (linha.Contains(tagNumeroDeDocumento))
                        dadosCadastrais.NumeroDoDocumento = linha.Replace(tagNumeroDeDocumento, "");
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

        public static void BuscaUsuarioPeloDocumento(List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            Console.WriteLine("Digite o número do documento para buscar o usuário ou digite S para sair");
            string tempOpcao = Console.ReadLine();

            if (tempOpcao.ToLower() == "s")
            {
                return;
            }
            else
            {
                List<DadosCadastraisStruct> ListaDeUsuariosTemp = ListaDeUsuarios.Where(x => x.NumeroDoDocumento == tempOpcao).ToList();
                if (ListaDeUsuariosTemp.Count > 0)
                {
                    foreach (DadosCadastraisStruct usuario in ListaDeUsuariosTemp)
                    {
                        Console.WriteLine(tagNome + usuario.Nome);
                        Console.WriteLine(tagDataNascimento + usuario.DataDeNascimento.ToString("dd/MM/yyyy"));
                        Console.WriteLine(tagNumeroDeDocumento + usuario.DataDeNascimento);
                        Console.WriteLine(tagNomeDaRua + usuario.NomeDaRua);
                        Console.WriteLine(tagNumeroDaCasa + usuario.NumeroDaCasa);
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum usuário possui o documento " + tempOpcao);
                }

                MostraMensagem("");

            }

        }

        public static void ExcluirUsuarioPeloDoc(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            Console.WriteLine("Digite o número do documento para excluir o usuário ou digite S para sair");
            string tempOpcao = Console.ReadLine();
            bool alguemFoiExcluido = false;

            if (tempOpcao.ToLower() == "s")
            {
                return;
            }
            else
            {
                List<DadosCadastraisStruct> ListaDeUsuariosTemp = ListaDeUsuarios.Where(x => x.NumeroDoDocumento == tempOpcao).ToList();
                if (ListaDeUsuariosTemp.Count > 0)
                {
                    foreach (DadosCadastraisStruct usuario in ListaDeUsuariosTemp)
                    {
                        ListaDeUsuarios.Remove(usuario);
                        alguemFoiExcluido = true;
                    }
                    if (alguemFoiExcluido)
                    {
                        GravaDados(caminhoArquivo, ListaDeUsuarios);
                        Console.WriteLine(ListaDeUsuariosTemp.Count + " usuário(s) com documento " + tempOpcao + "excluído(s)");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum usuário possui o documento: " + tempOpcao);
                }
                MostraMensagem("");

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
            tagNumeroDeDocumento = "NUMERO_DO_DOCUMENTO: ";

            caminhoArquivo = @"C:\temp\C#\Projeto34\baseDeDados.txt";

            CarregaDados(caminhoArquivo, ref ListaDeUsuarios);

            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário");
                Console.WriteLine("Digite B para buscar um usuário");
                Console.WriteLine("Digite E para excluir um usuário");
                Console.WriteLine("Digite S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if (opcao == "c")
                {
                    CadastraUsuario(ref ListaDeUsuarios);

                }
                else if (opcao == "b")
                {
                    BuscaUsuarioPeloDocumento(ListaDeUsuarios);
                }
                else if (opcao == "e")
                {
                    ExcluirUsuarioPeloDoc(ref ListaDeUsuarios);
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
