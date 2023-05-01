using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto20
{
    internal class Program
    {

        /*STRUCT*/
        struct dadosCadastrais
        {
            public string Nome;
            public string nomeDaRua;
            public UInt32 numeroDaCasa;
            public DateTime dataDeNascimento;
        }

        static void Main(string[] args)
        {

            /*SALVA DADOS NA STRUCT*/
            dadosCadastrais meuCadastro;

            meuCadastro.Nome = "Bruno Gabriel";
            meuCadastro.nomeDaRua = "Nova Petrópolis";
            meuCadastro.numeroDaCasa = 771;
            meuCadastro.dataDeNascimento = Convert.ToDateTime("10/07/1994");

            /*IMPRIME DADOS GUARDADOS*/
            Console.WriteLine(meuCadastro.Nome);
            Console.WriteLine(meuCadastro.nomeDaRua);
            Console.WriteLine(meuCadastro.numeroDaCasa);
            Console.WriteLine(meuCadastro.dataDeNascimento);
            Console.ReadKey();

        }
    }
}
