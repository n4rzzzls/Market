using System;
using System.Collections.Generic;

namespace Market
{
    class Cart
    {

        // Fields
        private int max_quantity = 20;
        private int current_capacity = 0;
        Good good;
        private List<Good> total_goods = new List<Good>();

        // Will add specified good into the cart
        public void AddGood(Storage storage, int good_id, int good_quantity)
        {
            if((current_capacity + good_quantity) <= max_quantity)
            {
                current_capacity += good_quantity;

                foreach (var r in storage.Goods)
                {
                    if (r.Id == good_id)
                    {
                        good = new Good(r.Id, r.Name, r.Price, good_quantity);
                        total_goods.Add(good);
                        Console.WriteLine("{0} in quantity of {1} was added to the cart.\nTotal: {2}/{3}", r.Name, r.Quantity, current_capacity, max_quantity);
                    }
                }
            }
            else
            {
                Console.WriteLine("The cart is full!");
            }
        }

        // Will remove specified good from cart
        public void RemoveGood(int good_id, int quantity)
        {

            foreach(var r in total_goods)
            {
                if(r.Id == good_id)
                {
                    if(r.Quantity == quantity)
                    {
                        total_goods.Remove(r);
                    }
                    else
                    {
                        r.Quantity -= quantity;
                    }
                }
            }
        }
    }
}
