using System;
using System.Globalization;

namespace AutoPropertie
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
            Console.WriteLine(produto.Name);
            Console.WriteLine(produto.Price);
            Console.WriteLine(produto.Qtd);

            Console.WriteLine("_____________________");
            Console.Write("Informe o novo nome: ");
            produto.Name = Console.ReadLine();
            Console.WriteLine("Nome atualizado: " + produto.Name);
        }
    }
}
