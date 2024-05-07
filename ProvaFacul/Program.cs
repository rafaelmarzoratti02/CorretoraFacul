using ProvaFacul.Classes;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int op = 0;
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

            


        } while (op != 0);

    }
}