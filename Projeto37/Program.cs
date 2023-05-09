using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A classe Pessoa não pode se instanciada, logo o código a baixo está incorreto*/
            //Pessoa minhaPessoa = new Pessoa("Bruno");

            Funcionario meuFuncionario = new Funcionario("Bruno", 10000);

            meuFuncionario.MostraNome();
            meuFuncionario.MostraSalario();
            Console.ReadKey();

        }
    }
}
