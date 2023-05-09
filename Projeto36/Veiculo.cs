using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto36
{
    internal class Veiculo
    {
        /*Atributos*/
        private uint numeroRodas;
        private uint numeroPortas;
        private uint velocidade;
        private bool estadoLigado;

        /*Propriedades*/
        public uint NumeroRodas
        {
            get { return numeroRodas; }
        }
        public uint NumeroPortas
        {
            get { return numeroPortas; }
        }
        public uint Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public bool EstadoLigado
        {
            get { return estadoLigado;}
        }
        
        /*Métodos*/
        public void Ligar()
        {
            Console.WriteLine("Veículo ligado!");
            estadoLigado = true;
        }
        public void Desligar()
        {
            Console.WriteLine("Veículo desligado!");
            estadoLigado = false;
        }

        /*Construtor*/
        public Veiculo(uint pNumeroRodas, uint pNumeroPortas)
        {
            this.numeroRodas = pNumeroRodas;
            this.numeroPortas= pNumeroPortas;
            velocidade= 0;
            estadoLigado= false;
        }

    }
}
