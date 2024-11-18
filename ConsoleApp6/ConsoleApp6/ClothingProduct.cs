using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class ClothingProduct : IProduct
    {
        private string name;
        private decimal price;
        private string description;

        public ClothingProduct(string name, decimal price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public string GetDescription()
        {
            return description;
        }

        public decimal CalculateDeliveryCost(decimal distance)
        {
            return distance * 0.8m;
        }
    }
}
