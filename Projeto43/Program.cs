using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Projeto43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly minhaDll = Assembly.LoadFile(@"C:\temp\C#\Projeto41\bin\Debug\Projeto41.dll");
            Type classeMatematica = minhaDll.GetType("Projeto41.Matematica");

            dynamic instanciaMatematica = Activator.CreateInstance(classeMatematica);
            var metodoSoma = classeMatematica.GetMethod("Soma");

            double resultado = (double)metodoSoma.Invoke(instanciaMatematica, new object[] { 10, 20 });

            Console.WriteLine("O resultado da soma de 10 e 20 é: " + resultado);
            Console.ReadKey();
        }
    }
}
