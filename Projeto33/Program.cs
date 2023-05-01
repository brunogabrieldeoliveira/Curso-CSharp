using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MANIPULANDO ARQUIVOS*/

            //escrevendo
            string caminho = @"C:\temp\C#\Projeto33\teste.txt";
            FileStream fs = File.Create(caminho);
            fs.Close();

            StreamWriter sw = new StreamWriter(caminho);

            sw.WriteLine('a');
            sw.WriteLine('-');
            sw.WriteLine("Olá mundo!");

            sw.Close();

            //lendo
            StreamReader sr1 = new StreamReader(caminho);
            char[] buffer = new char[128];

            sr1.Read(buffer, 4, 5);
            sr1.Read(buffer, 8, 7);
            sr1.Close();

            StreamReader sr2 = new StreamReader(caminho);
            string linha = sr2.ReadLine();
            linha = sr2.ReadLine();
            sr2.Close();

            StreamReader sr3 = new StreamReader(caminho);
            string arquivoInteiro = sr3.ReadToEnd();
            sr3.Close();




        }
    }
}
