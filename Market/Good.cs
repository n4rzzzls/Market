using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Good
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Good(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;

        }
    }
}
