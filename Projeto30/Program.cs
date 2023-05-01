using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\temp\C#\Projeto30\teste.txt";
            string caminhoArquivo2 = @"C:\temp\C#\Projeto30\teste2.txt";
            string texto1 = "João subiu no telhado. \r\n";
            string texto2 = "Luana, sua mãe, brigou com ele. \r\n";

            //maneira não muito correta
            string conteudoInicial = File.ReadAllText(caminhoArquivo);
            string conteudoFinal = conteudoInicial + texto1 + texto2;
            File.WriteAllText(caminhoArquivo, conteudoFinal);

            //maneira correta
            //File.AppendAllText(caminhoArquivo2, texto1);
            //File.AppendAllText(caminhoArquivo2, texto2);
            File.AppendAllText(caminhoArquivo2, texto1 + texto2);




        }
    }
}
