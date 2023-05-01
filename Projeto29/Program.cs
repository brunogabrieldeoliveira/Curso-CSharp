using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MANIPULANDO ARQUIVOS
            string caminho1 = "C:\\temp\\C#\\Projeto29\\teste1.txt";
            string caminho2 = @"C:\temp\C#\Projeto29\teste1.txt";

            //criando um arquivo
            FileStream meuArquivo = File.Create(caminho1);
            meuArquivo.Close();

            //verificando se o arquivo existe
            bool arquivoExiste = File.Exists(caminho1);
            if (arquivoExiste)
                Console.WriteLine("O arquivo existe");

            else
                Console.WriteLine("O arquivo não existe");

            //deletando arquivos
            File.Delete(caminho1);

            //renomeando ou movendo arquivos
            string caminho3 = @"C:\temp\C#\Projeto29\teste2.txt";
            FileStream meuArquivo2 = File.Create(caminho3);
            meuArquivo2.Close();
            string caminho4 = @"C:\temp\C#\Projeto29\teste3.txt";
            File.Move(caminho3, caminho4);

            File.Delete(caminho4);

            //excrevendo em um arquivo e texto
            string caminho5 = @"C:\temp\C#\Projeto29\nomes.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();

            string conteudo = "Marcos é um cara muito legal! \r\nPedro é um cara muito Inteligente!";
            File.WriteAllText(caminho5, conteudo);

            //escrvendo um array de string em nosso arquivo
            string[] conteudoArray = { "Guilherme", "Marcos", "Bianca" };
            File.WriteAllLines(caminho5, conteudoArray);

            //lendo todo o conteúdo de um arquivo
            string conteudoLido = File.ReadAllText(caminho5);
            Console.WriteLine(conteudoLido);

            //lendo o conteúdo de um arquivo e gravando em um array de strings
            Console.WriteLine("--------------------");
            string[] conteudoLidoArray = File.ReadAllLines(caminho5);
            foreach (string nomes in conteudoLidoArray)
            {
                Console.WriteLine(nomes);
            }


            Console.ReadKey();
        }
    }
}
