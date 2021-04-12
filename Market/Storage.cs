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

        // Will display available goods in the console
        public void DisplayGoods()
        {
            Console.WriteLine("\n\nID\tName\t\tPrice\tQuantity\n--\t----\t\t-----\t--------");
            foreach (Good item in goods)
            {
                Console.WriteLine("{0}\t{1, -10}\t{2}\t{3}", item.Id, item.Name, item.Price, item.Quantity);
            }
        }

        // 
        public void TakeGoodFromStorage(int good_id, int good_quantity)
        {
            foreach (var r in goods)
            {
                if (r.Id == good_id)
                {
                    if (r.Quantity >= good_quantity)
                    {
                        r.Quantity -= good_quantity;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient amount in the storage!");
                    }
                }
            }
        }

        // 
        public void AddGoodToStorage(int good_id, int good_quantity)
        {

            foreach (var r in goods)
            {
                if (r.Id == good_id)
                {
                    r.Quantity += good_quantity;

                }
            }
        }
    }
}
