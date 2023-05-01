using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*LISTAS*/

            List<string> listaDeNomes = new List<string>();

            //adicionando elementos
            listaDeNomes.Add("João");
            listaDeNomes.Add("Maria");
            listaDeNomes.Add("Jesus");

            foreach(string nomes in listaDeNomes)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("-----------");

            //removendo elementos
            listaDeNomes.Remove("João");

            foreach (string nomes in listaDeNomes)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("-----------");

            //removendo elementos em posições específicas
            listaDeNomes.RemoveAt(0); //remove Maria

            foreach (string nomes in listaDeNomes)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("-----------");

            List<string> listaDeNomes2 = new List<string>();

            Console.WriteLine("listaDeNomes2");

            //adicionando elementos
            listaDeNomes2.Add("João");
            listaDeNomes2.Add("Maria");
            listaDeNomes2.Add("Jesus");
            listaDeNomes2.Add("Pedro");

            //removendo uma faixa de elementos
            listaDeNomes2.RemoveRange(1, 2); //remove Maria e Jesus

            foreach (string nomes in listaDeNomes2)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("-----------");

            //pegando o numero de elementos da lista
            Console.WriteLine("Numero de elementos em listaDeNomes2: " + listaDeNomes2.Count);

            Console.WriteLine("-----------");

            //Concatendo duas listas

            List<string> listaDeNomes3 = new List<string>();

            //adicionando elementos
            listaDeNomes3.Add("João");
            listaDeNomes3.Add("Maria");
            listaDeNomes3.Add("Jesus");
            listaDeNomes3.Add("Pedro");

            List<string> listaDeNomes4 = new List<string>();

            //adicionando elementos
            listaDeNomes4.Add("Bruno");
            listaDeNomes4.Add("Catia");
            listaDeNomes4.Add("Amarildo");
            listaDeNomes4.Add("Lucas");

            List<string> listaDeNomesConcatenada = listaDeNomes3.Concat(listaDeNomes4).ToList();

            foreach (string nomes in listaDeNomesConcatenada)
            {
                Console.WriteLine(nomes);
            }

            //verificando se a lista possui um determinado valor
            bool contemNome = listaDeNomesConcatenada.Contains("Pedro");
            Console.WriteLine("A lista contém Perdro? " + contemNome);

            contemNome = listaDeNomesConcatenada.Contains("Tereza");
            Console.WriteLine("A lista contém Tereza? " + contemNome);

            //descobrundo o indice de um elemento
            int indice = listaDeNomesConcatenada.IndexOf("Bruno");
            Console.WriteLine("O indice do elemento Bruno é: " + indice );

            Console.WriteLine("-----------");


















            Console.ReadKey();


        }
    }
}
