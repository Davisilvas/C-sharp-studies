using System;
using System.Globalization;
using System.Xml.Linq;


namespace Propriedades
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _qtd;

        
        // CONSTRUCTORS
        public Product()
        {

        }

        public Product(string name, double price, int qtd)
        {
            _name = name;
            _price = price;
            _qtd = qtd;
        }

        // PROPERTIES
        public string Name
        {
            get { return _name; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public int Qtd
        {
            get { return _qtd; }
        }

        public double Price
        {
            get { return _price; }
        }

        // METHODS

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