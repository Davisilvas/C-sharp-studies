using System;


namespace stock
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Qtd;

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
