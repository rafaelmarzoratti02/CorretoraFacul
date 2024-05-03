using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFacul.Classes
{
    internal class Terreno : Imovel
    {
        public string tipo { get; set; }

        public Terreno(int cod, float valor, Endereco endereco, int areaTotal, string tipo) :base(cod, valor, endereco, areaTotal)
        {
            this.tipo = tipo;
        }   
    }
}
