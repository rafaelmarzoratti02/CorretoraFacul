using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFacul.Classes
{
    internal class Imovel
    {
        public int cod { get; set; }
        public float valor { get; set; }
        public Endereco endereco { get; set; }
        public int areaTotal { get; set; }



        public Imovel(int cod, float valor, Endereco endereco, int areaTotal)
        {
            this.cod = cod;
            this.valor = valor;
            this.endereco = endereco;
            this.areaTotal = areaTotal;
        }

   

    }
}
