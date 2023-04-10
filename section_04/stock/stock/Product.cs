using System;
using System.Globalization;


namespace stock
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Qtd;

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
