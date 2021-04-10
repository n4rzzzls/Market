using System;
using System.Collections.Generic;

namespace Market
{
    class Cart
    {

        // Fields
        private int max_goods = 5;
        private List<Good> total_goods;

        // Method. Will add specified good into the cart
        public void AddGood(Good good)
        {
            if (total_goods.Count < max_goods)
            {
                total_goods.Add(good);
                Console.WriteLine("{0}/{1}", total_goods.Count, max_goods);
            }
            else
            {
                Console.WriteLine("The cart is full.");
            }
        }

        //Method. Will remove specified good from cart
        public void RemoveGood(Good good)
        {

            total_goods.Remove(good);

        }

    }
}
