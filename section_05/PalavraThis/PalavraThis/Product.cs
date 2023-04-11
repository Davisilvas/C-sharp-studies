using System;
using System.Globalization;


namespace PalavraThis
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Qtd;

        public Product()
        {
            Qtd = 10;
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, int qtd) : this(name, price)
        {
            Qtd = qtd;
        }

        public override string ToString()
        {
            return Name + " - $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " - Quantidade em estoque: "
                + Qtd + " - Soma: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double ValorTotalEmEstoque()
        {
            return Price * Qtd;
        }

        public void AddProduct(int quantity)
        {
            Qtd = Qtd + quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Qtd = Qtd - quantity;
        }

    }
}
