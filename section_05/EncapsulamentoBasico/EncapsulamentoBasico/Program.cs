using System;
using System.Globalization;

namespace EncapsulamentoBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade de items no estoque: ");
            int qtd = int.Parse(Console.ReadLine()); 

            Product produto = new Product(name, price, qtd);

            Console.WriteLine("_____________________");
            Console.WriteLine(produto.GetName());
            Console.WriteLine(produto.GetPrice());
            Console.WriteLine(produto.GetQtd());

            Console.WriteLine("_____________________");
            Console.Write("Informe o novo nome: ");
            produto.SetNome(Console.ReadLine());
            Console.WriteLine("Nome atualizado: " + produto.GetName());
        }
    }
}