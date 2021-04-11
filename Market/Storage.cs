using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Storage
    {

        // Field
        private List<Good> goods = new List<Good>();

        // Property
        public List<Good> Goods
        {
            get { return goods; }
        }

        // Constructor
        public Storage()
        {
            goods.Add(new Good(1, "Banana", 10.14, 20));
            goods.Add(new Good(2, "Apple", 11.11, 22));
            goods.Add(new Good(3, "Tomato", 12.77, 24));
            goods.Add(new Good(4, "Cherry", 13.34, 26));
            goods.Add(new Good(5, "Watermelon", 14.89, 28));
            goods.Add(new Good(6, "Cucumber", 15.28, 30));
            goods.Add(new Good(7, "Merry", 16.61, 32));

        }

        // Method. Will display available goods in the console
        public void DisplayGoods()
        {
            Console.WriteLine("\n\nID\tName\t\tPrice\tQuantity\n--\t----\t\t-----\t--------");
            foreach (Good item in goods)
            {
                Console.WriteLine("{0}\t{1, -10}\t{2}\t{3}", item.Id, item.Name, item.Price, item.Quantity);
            }
        }

        public void TakeGoodFromStorage(Good good, Storage storage, int quantity)
        {
            foreach (var r in storage.Goods)
            {
                if (r == good)
                {
                    if (r.Quantity >= quantity)
                    {
                        r.Quantity -= quantity;
                    }
                }

            }
        }
    }
}
