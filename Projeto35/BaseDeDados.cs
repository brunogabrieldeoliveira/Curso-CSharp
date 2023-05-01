using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto35
{
    internal class BaseDeDados
    {
        /*Atributos*/
        private List<CadastroPessoa> listaDePessoas;

        /*Métodos*/
        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);
        }

        public List<CadastroPessoa> PesquisaPessoaPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x=>x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            if (listaDePessoasTemp.Count > 0)
            {
                return listaDePessoasTemp;
            }
            else
            {
                return null;
            }                
        }

        public List<CadastroPessoa> RemoverPessoaPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            if (listaDePessoasTemp.Count > 0)
            {
                foreach (CadastroPessoa nome in listaDePessoasTemp)
                {
                    listaDePessoas.Remove(nome);
                }

                return listaDePessoasTemp;
            }
            else
            {
                return null;
            }

        }

        /*Construtor*/
        public BaseDeDados()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }
    }
}
