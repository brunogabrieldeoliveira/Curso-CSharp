using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            Bicicleta minhaBicicleta = new Bicicleta();

            meuCarro.Anda();
            minhaBicicleta.Anda();

            Console.ReadKey();
        }
    }
}
