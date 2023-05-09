using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cozinha cozinhaHamburguer = new Cozinha();
            Cozinha cozinhaJaponesa = new Cozinha();

            TabletGarcom tabletJoao = new TabletGarcom("João", cozinhaHamburguer);
            TabletGarcom tabletPedro = new TabletGarcom("Pedro", cozinhaHamburguer);
            TabletGarcom tabletMaria = new TabletGarcom("Maria", cozinhaHamburguer);

            TabletGarcom tabletJoana = new TabletGarcom("Joana", cozinhaJaponesa);
            TabletGarcom tabletAline = new TabletGarcom("Aline", cozinhaJaponesa);
            TabletGarcom tabletMarcos = new TabletGarcom("Marcos", cozinhaJaponesa);

            cozinhaHamburguer.EnviaMensagemPedidoPronto(12);
            cozinhaJaponesa.EnviaMensagemPedidoPronto(29);

            Console.ReadKey();

        }
    }
}
