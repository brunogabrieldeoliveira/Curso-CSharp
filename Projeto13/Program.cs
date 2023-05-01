using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laço for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }

            //Laço while
            int j = 0;
            while (j<100)
            {
                Console.WriteLine(j);
                j += 10;

            }

            //Laço do while
            int k = 0;
            do
            {
                Console.WriteLine("Boa tarde!");
                k += 100;

            } while (k<1000);

            //Laço for each
            string[] nomes = { "Guilherme", "João", "Pedro", "Maria", "Paula" };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
