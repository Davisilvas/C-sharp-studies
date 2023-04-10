using System;
using System.Globalization;

namespace stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product produto;
            produto = new Product();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Name = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade de items no estoque: ");
            produto.Qtd = int.Parse(Console.ReadLine());

            double valorTotal = produto.ValorTotalEmEstoque();

            Console.WriteLine("Dados do produto: " + produto.Name + " - $" + produto.Price + " - " + produto.Qtd + " - Total: $" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("################################");

            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int addition = int.Parse(Console.ReadLine());
            produto.AddProduct(addition);
            double valorAcrescido = produto.ValorTotalEmEstoque();

            Console.WriteLine("Dados atualizados: " + produto.Name + " - $" + produto.Price + " - " + produto.Qtd + " - Total: $" + valorAcrescido.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("################################");

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int remove = int.Parse(Console.ReadLine());
            produto.RemoveProduct(remove);
            double valorDecrescido = produto.ValorTotalEmEstoque();

            Console.WriteLine("Dados atualizados: " + produto.Name + " - $" + produto.Price + " - " + produto.Qtd + " - Total: $" + valorDecrescido.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}