using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de 1 dimensão
            int[] meuArray = new int[3];
            meuArray[0] = 1;
            meuArray[1] = 10;
            meuArray[2] = 100;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine("----------------");

            //outras maneiras de criar
            int[] meuArray2 = { 1, 10, 100 };

            Console.WriteLine(meuArray2[0]);
            Console.WriteLine(meuArray2[1]);
            Console.WriteLine(meuArray2[2]);
            Console.WriteLine("----------------");

            int[] meuArray3 = new int[] { 1, 10, 100 };
            Console.WriteLine(meuArray3[0]);
            Console.WriteLine(meuArray3[1]);
            Console.WriteLine(meuArray3[2]);
            Console.WriteLine("----------------");

            //Array de duas dimensões
            string[,] meuArray4 = new string[2, 3];

            meuArray4[0, 0] = "1";
            meuArray4[0, 1] = "2";
            meuArray4[0, 2] = "3";
            meuArray4[1, 0] = "11";
            meuArray4[1, 1] = "12";
            meuArray4[1, 2] = "13";

            Console.WriteLine(meuArray4[0, 0]);
            Console.WriteLine(meuArray4[0, 1]);
            Console.WriteLine(meuArray4[0, 2]);
            Console.WriteLine(meuArray4[1, 0]);
            Console.WriteLine(meuArray4[1, 1]);
            Console.WriteLine(meuArray4[1, 2]);
            Console.WriteLine("----------------");

            //outras maneiras de incializar um array de duas dimensões
            string[,] meuArray5 = { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.WriteLine(meuArray5[0, 0]);
            Console.WriteLine(meuArray5[0, 1]);
            Console.WriteLine(meuArray5[0, 2]);
            Console.WriteLine(meuArray5[1, 0]);
            Console.WriteLine(meuArray5[1, 1]);
            Console.WriteLine(meuArray5[1, 2]);
            Console.WriteLine("----------------");

            string[,] meuArray6 = new string[,] { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.WriteLine(meuArray6[0, 0]);
            Console.WriteLine(meuArray6[0, 1]);
            Console.WriteLine(meuArray6[0, 2]);
            Console.WriteLine(meuArray6[1, 0]);
            Console.WriteLine(meuArray6[1, 1]);
            Console.WriteLine(meuArray6[1, 2]);
            Console.WriteLine("----------------");

            //numero de elementos do vetor
            int tamanho1 = meuArray6.GetLength(0);
            int tamanho2 = meuArray6.GetLength(1);
            Console.WriteLine("A primeira dimensão do meu Array6 possui: " + tamanho1 + " elementos!");
            Console.WriteLine("A segunda dimensão do meu Array6 possui: " + tamanho2 + " elementos!");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();  
        }
    }
}
