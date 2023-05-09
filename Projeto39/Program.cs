using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Globalization;

namespace Projeto39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Bilu", "Boxer", "Marron");
            Cachorro meuCachorroDesserializado;

            DataContractSerializer serealizador = new DataContractSerializer(typeof(Cachorro));

            //Serelalização
            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter escritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            serealizador.WriteObject(escritorDeXml, meuCachorro);
            escritorDeXml.Flush();
            string objetoSerealizadoStr = construtorDeString.ToString();

            string objetoSelerealizador = construtorDeString.ToString();

            //Salvando o conteúdo do xml em um arquivo
            string caminhoXml = "cachorro.xml";
            FileStream meuArquivoXml = File.Create(caminhoXml);
            meuArquivoXml.Close();
            File.WriteAllText(caminhoXml, objetoSerealizadoStr);

            //Desserealização
            string conteudoDoObjetoSerializado = File.ReadAllText(caminhoXml);
            StringReader leitorDeStrings = new StringReader(conteudoDoObjetoSerializado);
            XmlReader leitorDeXml = XmlReader.Create(leitorDeStrings);
            meuCachorroDesserializado = (Cachorro)serealizador.ReadObject(leitorDeXml);

            escritorDeXml.Close();
            leitorDeXml.Close();
            
        }
    }
}
