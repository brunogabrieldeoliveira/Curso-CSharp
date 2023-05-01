using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            UInt32 idade = Convert.ToUInt32(Console.ReadLine());

            /*if else*/
            if (idade < 18)
            {
                Console.WriteLine("Idade menor que 18!");

            }
            else if (idade == 18)
            {
                Console.WriteLine("Idade igual que 18!");

            }
            else /*caso contrário*/
            {
                Console.WriteLine("Idade maior que 18!");

            }

            Console.WriteLine("Pressione uma tecla do seu teclado: ");
            char tecla = char.ToLower(Convert.ToChar(Console.ReadKey(true).KeyChar));

            /*switch(comutador)*/
            switch (tecla)
            {
                case 'a':
                    Console.WriteLine("Você pressionou 'a' !");
                    break;

                case 'b':
                    Console.WriteLine("Você pressionou 'b' !");
                    break;

                default:
                    Console.WriteLine("Tecla desconhecida!");
                    break;

            } // fim switch


            Console.WriteLine("Digite qualquer tecla para sair...");
            Console.ReadKey();



        }
    }
}
