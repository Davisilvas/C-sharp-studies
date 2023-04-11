using System;
using System.Globalization;

namespace PalavraThis
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

            /* Console.Write("Quantidade de items no estoque: ");
            int qtd = int.Parse(Console.ReadLine()); */

            Product produto = new Product(name, price);

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int addition = int.Parse(Console.ReadLine());
            produto.AddProduct(addition);

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int remove = int.Parse(Console.ReadLine());
            produto.RemoveProduct(remove);

            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}
