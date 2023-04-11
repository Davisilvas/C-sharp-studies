using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

    /*
    Ordem sugerida
    • Atributos privados
    • Propriedades autoimplementadas
    • Construtores
    • Propriedades customizadas
    • Outros métodos da classe */

namespace AutoPropertie
{
    internal class Product
    {
        // se o valor tem uma lógica particular como o _name, não da pra aplicar a auto prop. No caso de _name, ela tem uma lógica de validação.
        
        private string _name;
        public int Qtd { get; private set; }
        public double Price { get; private set; }



        // CONSTRUCTORS
        public Product()
        {

        }

        public Product(string name, double price, int qtd)
        {
            _name = name;
            Price = price;
            Qtd = qtd;
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

        // METHODS
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

        public override string ToString()
        {
            return _name + " - $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " - Quantidade em estoque: "
                + Qtd + " - Soma: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
