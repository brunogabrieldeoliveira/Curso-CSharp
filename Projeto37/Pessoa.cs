using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto37
{

    /*Modificador Abstract*/
    //Esta classe não pode ser instanciada, somente herdada

    internal abstract class Pessoa
    {
        /*atibutos*/
        private string nome;

        /*propriedades*/
        public string Nome
        {
            get { return nome; }
        }

        /*metodos*/
        public void MostraNome()
        {
            Console.WriteLine("O nome da pessoa é: " + nome);
        }

        /*construtor*/
        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }
}
