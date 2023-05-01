using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FATORIAL*/
            while (true)
            {

                Console.WriteLine("Digite S para sair ou um número para calcular o fatorial: ");
                string opcao = Console.ReadLine();

                if (opcao == "s" || opcao == "S")
                {
                    break;
                }
                else
                {
                    //ignora opcao em branco
                    if (opcao == "")
                    {
                        continue;
                    }

                    int valor = Convert.ToInt32(opcao);

                    if (valor == 0)
                    {
                        Console.WriteLine("0! = 1");
                    }
                    else if (valor < 0)
                    {
                        Console.WriteLine("Impossível calcula fatorial de números negativos!");
                    } 
                    else
                    {
                        int resultado = 1;
                        for (int i = valor; i > 0; i--)
                        {
                            resultado *= i;
                        }

                        Console.WriteLine("O fatorial de " + valor + " é :" + resultado);
                        Console.ReadKey();
                        Console.Clear();
                    } 
                } 
            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
