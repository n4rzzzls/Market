using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Customer
    {

        // Field
        private Balance balance;
        private Cart cart;

        // Property
        public Balance Balance
        {
            get { return balance; }
        }

        // Constructor
        public Customer()
        {
            balance = new Balance();
            cart = new Cart();
        }

        // Method.
        public void Purchase()
        {

        }

        // Method.
        public void SelectGood(Good good, Storage storage, int quantity)
        {

            storage.TakeGoodFromStorage(good, storage, quantity);
            cart.AddGood(good);
        }

    }
}
