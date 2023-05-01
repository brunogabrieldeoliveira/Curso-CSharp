using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*OPERADORES MATEMÁTICOS  AVANÇADOS*/

            //Potencialização
            double potencializacao = Math.Pow(4, 2);
            Console.WriteLine("Quatro elevado ao quadrado é: " + potencializacao);

            //Radiciação
            double raiz = 3;
            double radiaciacao = Math.Pow(27, 1 / raiz);
            Console.WriteLine("A raíz cúbida de 27 é: " + radiaciacao);

            //Máximo e o Mínimo
            double maximo = Math.Max(8, 4);
            Console.WriteLine(maximo);

            double minimo = Math.Min(8, 4);
            Console.WriteLine(minimo);

            //Módulo
            double modulo = Math.Abs(-10);
            Console.WriteLine(modulo);


            //Operações trigonométricas

            double angulo = 30 * (2 * Math.PI) / 360;

            /*
             seno - Sin
             cosseno - Cos
             tangente - Tan
            */

            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);

            /*
             Arcseno - Asin
             Arccosseno - Acos
             Arctangente - Atan
            */

            double arseno = Math.Asin(seno);
            Console.WriteLine(arseno);

            //convertendo em graus
            double arcsenoGraus = arseno * 360 / (2 * Math.PI);
            Console.WriteLine(arcsenoGraus);


            //Arredondando números

            double numero = 3.33;
            double arredondaParaCima = Math.Ceiling(numero);
            Console.WriteLine(arredondaParaCima);

            double arredondaParaBaixo = Math.Floor(numero);
            Console.WriteLine(arredondaParaBaixo);

            //Logaritmo
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);

            double baseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(baseE);


            Console.ReadKey();



        }
    }
}
