using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
       

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> BagOfProducts { get; set; }

        public void BuyProduct(Product product)
        {
            if (this.Money<product.Cost)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.BagOfProducts.Add(product);
            this.Money -= product.Cost;
        }
    }
}
