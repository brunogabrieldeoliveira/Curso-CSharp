using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Projeto39
{
    [DataContract]
    internal class Cachorro
    {
        [DataMember]
        private string Nome { get; set; }
        [DataMember]
        public string raca;
        [DataMember]
        public string cor;

        public Cachorro(string pNome, string pRaca, string pCor)
        {
            Nome= pNome;
            raca= pRaca;
            cor= pCor;
        }

        public Cachorro() 
        { 
        
        }

    }
}
