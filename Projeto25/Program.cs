using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EXCEÇÕES 2 - FORÇANDO EXECEÇÕES*/

            try
            {
                Console.WriteLine("Digite qualquer número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)
                {
                    throw new Exception("O número digitado " + numero + " é menor que 0!");
                }
                else
                {
                    throw new Exception("O número digitado " + numero + " é maior que 0!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para sair ...");
                Console.ReadKey();

            }


        }
    }
}
