using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFacul.Classes
{
    internal abstract class Imovel
    {
        public int cod { get; set; }
        static int _cod = 20240001;
        public float valor { get; set; }
        public Endereco endereco { get; set; }
        public int areaTotal { get; set; }



        public Imovel(float valor, Endereco endereco, int areaTotal)
        {
            this.cod = geraCod();
            this.valor = valor;
            this.endereco = endereco;
            this.areaTotal = areaTotal;
        }

        virtual public void ExibirDetalhes()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Codígo: " + this.cod);
            Console.WriteLine("Valor: " + this.valor);
            Console.WriteLine("Endereco: ");
            Console.WriteLine("Area Total: " + this.areaTotal);

        }

        public int geraCod()
        {
            return _cod++;
        }

        virtual public float CalcularIptu()
        {
            return 1;
        }

    }
}
