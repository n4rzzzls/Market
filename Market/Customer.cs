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
            Console.WriteLine("\n---\nBalance in cash is {0};\nCard balance is {1}", balance.Balance_cash, balance.Balance_card);
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


        public void RemoveGood(int selected_good_id, int quantity)
        {

        }

    }
}
