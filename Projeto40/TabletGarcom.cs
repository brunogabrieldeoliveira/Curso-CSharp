using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto40
{
    internal class TabletGarcom
    {
        private string nome;

        public void MostraMensagemPedidoProntoNaCozinha(object fonte, EventArgsPedidoPronto e)
        {
            Console.WriteLine("O pedido " + e.NumeroPedido + " está pronto na cozinha, " + nome);
        }

        public TabletGarcom(string pNome, Cozinha pCozinha)
        {
            nome = pNome;
            pCozinha.MensagemPedidoProntoEvent += MostraMensagemPedidoProntoNaCozinha;
        }
    }
}
