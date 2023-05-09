using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto36
{
    internal class Aviao:Veiculo
    {
        /*Atributos*/
        private uint altitude;

        /*Propriedades*/
        public uint Altitude
        {
            get { return altitude; }
        }

        /*Metodos*/
        public void Decolar(uint pVelocidade, uint pAltitude)
        {
            if (EstadoLigado == false)
                Console.WriteLine("Avião desligado!");
            else
            {
                Console.WriteLine("Avião decolando...");
                altitude = pAltitude;
                Velocidade = pVelocidade;
                Console.WriteLine("Velocidade do avião: " + Velocidade);
                Console.WriteLine("Altitude do aviao: " + altitude);
            }
                
        }

        public void Pousar()
        { 
            Console.WriteLine("Avião pousando...");
            altitude = 0;
            Velocidade = 0;
            Console.WriteLine("Velocidade do avião: " + Velocidade);
            Console.WriteLine("Altitude do aviao: " + altitude);
        }

        /*Construtor*/
        public Aviao(uint pNumeroRodas, uint pNumeroPortas): base(pNumeroRodas, pNumeroPortas)
        {

        }

    }
}
