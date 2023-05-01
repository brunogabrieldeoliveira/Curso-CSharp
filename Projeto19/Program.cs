using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto19
{
    internal class Program
    {
        /*ENUMS*/
        enum notasDeReal_e
        {
            nota0 = 0,
            nota5 = 5,
            nota7 = 7,
            nota10= 10
        }


        static void Main(string[] args)
        {
            int nota = Convert.ToInt32(notasDeReal_e.nota7);
            Console.WriteLine(nota);

            Console.WriteLine("Pressione qualquer tecla para sair ...");
            Console.ReadKey();


        }
    }
}
