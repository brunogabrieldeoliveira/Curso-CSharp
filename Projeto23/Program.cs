using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*QUEUE - FILA*/

            Queue<string> filaDeNomes = new Queue<string>();

            //adicionando elementos
            filaDeNomes.Enqueue("Jesus");
            filaDeNomes.Enqueue("Maria");
            filaDeNomes.Enqueue("José");
            filaDeNomes.Enqueue("Pedro");
            filaDeNomes.Enqueue("Lucas");

            //removendo elementos
            string nomeRemovido = filaDeNomes.Dequeue();    
            Console.WriteLine(nomeRemovido);
            nomeRemovido = filaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);

            //espiando elementos
            Console.WriteLine("-------------");
            string nomeEspiado = filaDeNomes.Peek();
            Console.WriteLine(nomeEspiado);

            /*STACK - PILHA*/
            Console.WriteLine("-------------");
            Stack<string> pilhaDeNomes = new Stack<string>();

            //adicionando elementos
            pilhaDeNomes.Push("Mariana");
            pilhaDeNomes.Push("Camila");
            pilhaDeNomes.Push("Tereza");
            pilhaDeNomes.Push("Catia");
            pilhaDeNomes.Push("Célia");

            //removendo elementos
            string nomeRemovido2 = pilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            nomeRemovido2 = pilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            Console.WriteLine("-------------");

            //espiar elementos
            string nomeEspiado2 = pilhaDeNomes.Peek();
            Console.WriteLine(nomeEspiado2);

            /*
                possuem os mesmos métodos das listas
                Count, Clear, Concat, Contains ...
             */

            Console.ReadKey();



        }
    }
}
