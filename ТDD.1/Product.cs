using System;

namespace ТDD._1
{
    internal class Product
    {
        private decimal _price;
        public string Name { get; }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentException("Price must be a positive value.");
                _price = value;
            }
        }
        public int Quantity { get; }

        

        public Product(string name, decimal price, int quantity)
        {
            
            Name = "Test Product";
            _price = 10.5m;
            Quantity = 3;
        }
    }
}