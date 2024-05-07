using ProvaFacul.Classes;
using System.Collections;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Imovel> imoveis = new List<Imovel>();
        string logradouro;
        string bairro;
        string complemento;
        string cep;
        string cidade;
        string tipo;
        string estado;
        Endereco end;


        float areaConstruida, areaPrivativa, valor;
        int op = 0, areaTotal;


        do
        {


            Console.WriteLine("-------------------------");
            Console.WriteLine("1) Cadastrar Casa");
            Console.WriteLine("2) Cadastrar Apto");
            Console.WriteLine("3) Cadastrar Terreno");
            Console.WriteLine("4) Listar imóveis");
            Console.WriteLine("0) Sair");
            Console.WriteLine("_________________________");
            Console.Write("Digite a opção desejada: ");
            op = int.Parse(Console.ReadLine()!);




            if (op != 4 && op != 0)
            {
            Console.Clear();
            Console.WriteLine("Informe o Endereço:");
            Console.Write("\n- Logradouro: ");
            logradouro = Console.ReadLine()!;
            Console.Write("\n- Bairro: ");
            bairro = Console.ReadLine()!;
            Console.Write("\n- Complemento: ");
            complemento = Console.ReadLine()!;
            Console.Write("\n- CEP: ");
            cep = Console.ReadLine()!;
            Console.Write("\n- Cidade: ");
            cidade = Console.ReadLine()!;
            Console.Write("\n- Estado: ");
            estado = Console.ReadLine()!;
            Console.Write("\nInforme a área total: ");
            areaTotal = int.Parse(Console.ReadLine()!);
            Console.Write("\nInforme o valor: ");
            valor = int.Parse(Console.ReadLine()!);

            end = new Endereco(logradouro, bairro, complemento, cep, cidade, estado);



            switch (op)
                {
                    case 1:
                        Console.Write("\nInforme a Área Construiída: ");
                        areaConstruida = float.Parse(Console.ReadLine()!);
                        Casa c = new Casa(valor, end, areaTotal, areaConstruida);
                        imoveis.Add(c);
                        Console.WriteLine("Adicionando...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("\nInforme a Área Privativa: ");
                        areaPrivativa = float.Parse(Console.ReadLine()!);
                        Apto ap = new Apto(valor, end, areaTotal, areaPrivativa);
                        imoveis.Add(ap);
                        Console.WriteLine("Adicionando...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("\nInforme o tipo: ");
                        tipo = Console.ReadLine()!;
                        Terreno t = new Terreno(valor, end, areaTotal, tipo);
                        imoveis.Add(t);
                        Console.WriteLine("Adicionando...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 0:
                        break;
                    default:
                        break;

                }
            }
            else
            {
                if(op == 4)
                {
                    if (imoveis.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Você não possue nenhum imóvel cadastrado!");
                        Console.WriteLine("Retornando ao menu principal...");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.Clear();
                        foreach (Imovel i in imoveis)
                        {
                            i.ExibirDetalhes();
                        }
                        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal...");
                        Console.ReadKey();
                    }
                   

                } else
                {
                    Console.WriteLine("Adeus!");
                    op = 0;
                }

            }
            Console.Clear();

        } while (op != 0);

    }
}
