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

        // 
        public void Purchase()
        {

        }

        // 
        public void SelectGood(Storage storage, int selected_good_id, int selected_good_quantity)
        {

            storage.TakeGoodFromStorage(selected_good_id, selected_good_quantity);
            cart.AddGood(storage, selected_good_id, selected_good_quantity);

        }

        // 
        public void RemoveGood(Storage storage, int selected_good_id, int selected_good_quantity)
        {

            storage.AddGoodToStorage(selected_good_id, selected_good_quantity);
            cart.RemoveGood(selected_good_id, selected_good_quantity);

        }

    }
}
