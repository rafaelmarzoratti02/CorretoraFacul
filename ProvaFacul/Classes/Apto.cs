using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFacul.Classes
{
    internal class Apto: Imovel
    {

        public float areaPrivativa { get; set; }



        public Apto(float valor, Endereco endereco, int areaTotal, float areaPrivativa) : base( valor, endereco, areaTotal)
        {
            this.areaPrivativa = areaPrivativa;
        }


        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
        }

        public override float CalcularIptu()
        {
            return base.CalcularIptu();
        }


    }
}
