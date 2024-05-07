using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFacul.Classes
{
    internal class Endereco
    {
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }


        public Endereco(string logradouro, string bairro, string complemento,string cep, string cidade, string estado)
        {
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;

        }

        public void ExibirEndereco()
        {
            Console.WriteLine($"- Logradouro: {this.logradouro} ");
            Console.WriteLine($"- Bairro: {this.bairro} ");
            Console.WriteLine($"- Complemento: {this.complemento} ");
            Console.WriteLine($"- CEP: {this.cep} ");
            Console.WriteLine($"- Cidade: {this.cidade} ");
            Console.WriteLine($"- Estado: {this.estado} ");


        }


    }


}
