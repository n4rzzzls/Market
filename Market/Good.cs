using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Good
    {
        private int id;
        private string name;
        private double price;
        private double quantity;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public Good(int id, string name, double price, double quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;

        }
    }
}
