using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto38
{
    internal class Carro:Veiculo
    {
        override public void Anda()
        {
            Console.WriteLine("O carro está andando...");
        }
    }
}
