using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFacul.Classes
{
    internal class Casa : Imovel
    {

        public float areaConstruida { get; set; }

        public Casa(float valor, Endereco endereco, int areaTotal, float areaConstuida) : base(valor, endereco, areaTotal)
        {
            this.areaConstruida = areaConstuida;
        }


        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Área construída: {this.areaConstruida}");
        }

        public override float CalcularIptu()
        {
            return base.CalcularIptu();
        }
    }
}
