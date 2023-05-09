using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto37
{
    internal class Funcionario : Pessoa
    {

        /*atributos*/
        private UInt32 salario;

        /*propriedades*/
        public UInt32 Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        /*metodos*/
        public void MostraSalario()
        {
            Console.WriteLine("O salário do funcionário " + Nome + " é: " + Salario);
        }
        public Funcionario(string pNome, UInt32 pSalario):base(pNome)
        {
            salario = pSalario;
        }

    }
}
