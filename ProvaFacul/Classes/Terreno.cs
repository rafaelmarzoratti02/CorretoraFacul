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

        public Terreno( float valor, Endereco endereco, int areaTotal, string tipo) : base( valor, endereco, areaTotal)
        {
            this.tipo = tipo;
        }


        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Tipo:{this.tipo} ");
        }

        public override float CalcularIptu()
        {
            return base.CalcularIptu();
        }

    }
}
