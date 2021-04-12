using System;
using System.Collections.Generic;

namespace Market
{
    class Cart
    {

        // Fields
        private int max_goods = 5;
        private List<Good> total_goods = new List<Good>();

        // Will add specified good into the cart
        public void AddGood(Storage storage, int good_id)
        {
            if(total_goods.Count < max_goods)
            {
                foreach (var r in storage.Goods)
                {
                    if (r.Id == good_id)
                    {
                        total_goods.Add(r);
                        Console.WriteLine("Cart volume: {0}/{1}", total_goods.Count, max_goods);
                    }
                }
            }
            else
            {
                Console.WriteLine("The cart is full!");
            }
        }

        // Will remove specified good from cart
        public void RemoveGood(Good good)
        {

            total_goods.Remove(good);

        }

    }
}
