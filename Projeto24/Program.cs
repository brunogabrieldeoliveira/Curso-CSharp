using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EXCEÇÕES*/

            Console.WriteLine("Digite um número: ");            

            try 
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int resultado = 10 / i;
                Console.WriteLine("Resultado da divisão: " + resultado);
            
            }
            catch (DivideByZeroException e)
            { 
                Console.WriteLine("Exceção: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Digite qualquer tecla para sair...");
                Console.ReadKey();
            }





        }
    }
}
