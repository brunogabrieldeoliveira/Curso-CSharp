using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Projeto44___Usando_DLLs_Nativas_1
{
    internal class CascaDLLNativa
    {
        [DllImport(@"C:\temp\C#\Projeto44 - Usando DLLs Nativas 1\DLL\DLL_Nativa.dll",
                   CallingConvention = CallingConvention.Cdecl)]
        public static extern double Soma(double a, double b);

        [DllImport(@"C:\temp\C#\Projeto44 - Usando DLLs Nativas 1\DLL\DLL_Nativa.dll",
                   CallingConvention = CallingConvention.Cdecl)]
        public static extern double Media(double [] a, int quantidade);

        [DllImport(@"C:\temp\C#\Projeto44 - Usando DLLs Nativas 1\DLL\DLL_Nativa.dll",
                   CallingConvention = CallingConvention.Cdecl)]
        public static extern double RecebeVetor([In, Out] int[] valor, int Tamanho);

        [DllImport(@"C:\temp\C#\Projeto44 - Usando DLLs Nativas 1\DLL\DLL_Nativa.dll",
                   CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EnviaFrase(char[] Frase);

        [DllImport(@"C:\temp\C#\Projeto44 - Usando DLLs Nativas 1\DLL\DLL_Nativa.dll",
                   CallingConvention = CallingConvention.Cdecl)]
        public static extern double PegaFrase([In, Out] char[] Frase, int Tamanho);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultadoSoma = CascaDLLNativa.Soma(10, 20);
            Console.WriteLine("O resultado da soma é: " + resultadoSoma);
            Console.WriteLine("-------------------------------------------------");

            double[] valoresMedia = { 10, 20, 30 };
            double resultadoMedia = CascaDLLNativa.Media(valoresMedia, valoresMedia.Length);
            Console.WriteLine("O resultado da média é: " + resultadoMedia);
            Console.WriteLine("-------------------------------------------------");

            int[] meuVetorInt = new int[3];

            CascaDLLNativa.RecebeVetor(meuVetorInt, meuVetorInt.Length);
            if (meuVetorInt.Length > 0)
                Console.WriteLine("Vetor recebido corretamente!");
            else
                Console.WriteLine("Vetor não recebido corretamente");
            Console.WriteLine("-------------------------------------------------");

            char[] charEnviaFrase1 = ("EnviaFrase").ToCharArray();
            bool resultadoEnviaFrase1 = CascaDLLNativa.EnviaFrase(charEnviaFrase1);
            if (resultadoEnviaFrase1)
                Console.WriteLine("Frase enviada com sucesso!");
            else
                Console.WriteLine("Frase NAO enviada com sucesso!");
            Console.WriteLine("-------------------------------------------------");

            char[] chPegaFrase = new char[128];
            CascaDLLNativa.PegaFrase(chPegaFrase, chPegaFrase.Length);
            string strPegaFrase = new string(chPegaFrase);
            Console.WriteLine(strPegaFrase);

            Console.ReadKey();

        }
    }
}
