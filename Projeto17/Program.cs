using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MANIPULAÇÃO DE STRINGS*/

            //indexação
            string nome = "Bruno Gabriel de ";
            Console.WriteLine(nome[4]);

            //concatenar strings
            string sobrenome = "Oliveira";
            string nomeCompleto = nome + sobrenome;
            Console.WriteLine(nomeCompleto);

            string nomeCompleto2 = String.Concat(nome, sobrenome);
            Console.WriteLine(nomeCompleto2);

            //substituição de string
            string endereco = "Nova Petrópolis";
            endereco = endereco.Replace("Petrópolis","Parobé");
            Console.WriteLine(endereco);

            //remoção de strings
            string endereco2 = "Nova Petrópolis";
            endereco2 = endereco2.Replace("Petrópolis", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Nova Petrópolis";
            endereco3 = endereco3.Remove(0, 5);
            Console.WriteLine(endereco3);

            //capitalização de strings
            string nome2 = "João da Silva";
            nome2 = nome2.ToUpper();
            Console.WriteLine(nome2);
            nome2 = nome2.ToLower();
            Console.WriteLine(nome2);

            //contém
            string nome3 = "João da Silva";
            bool contem = nome3.Contains("João");
            Console.WriteLine(contem);
            contem = nome3.Contains("Marcos");
            Console.WriteLine(contem);

            //localização de textos
            string nome4 = "João da Silva";
            int indice = nome4.IndexOf("da");
            Console.WriteLine(indice);

            //divisão de strings
            string nome5 = "João da Silva";
            string[] divisores = { "da " };
            string[] resultadoDaDivisao = nome5.Split(divisores, StringSplitOptions.None);
            foreach (string texto in resultadoDaDivisao)
            {
                Console.WriteLine(texto);
            }

            //numero de caracteres
            string nome6 = "João da Silva";
            int numeroDeCaracteres = nome6.Length;
            Console.WriteLine(numeroDeCaracteres);

            //substring
            string nome7 = "João da Silva";
            string ultimoNome = nome7.Substring(8, 5);
            Console.WriteLine(ultimoNome);

            //formatação composta
            string nome8 = "João {0} {1}";
            Console.WriteLine(nome8, "da Silva", "Sauro");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            


        }
    }
}
