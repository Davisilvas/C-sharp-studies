using System;
using System.Globalization;


namespace EncapsulamentoBasico
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _qtd;

        public Product()
        {
         
        }

        public Product(string name, double price, int qtd)
        {
            _name = name;
            _price = price;
            _qtd = qtd;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetNome(string name)
        {
            _name = name;
        }

        public int GetQtd()
        {
            return _qtd;
        }

        public double GetPrice()
        {
            return _price;
        }

        public override string ToString()
        {
            return _name + " - $"
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + " - Quantidade em estoque: "
                + _qtd + " - Soma: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double ValorTotalEmEstoque()
        {
            return _price * _qtd;
        }

        public void AddProduct(int quantity)
        {
            _qtd = _qtd + quantity;
        }

        public void RemoveProduct(int quantity)
        {
            _qtd = _qtd - quantity;
        }

    }
}
