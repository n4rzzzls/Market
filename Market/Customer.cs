using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Customer
    {
        private Balance balance;
        public Balance Balance
        {
            get { return balance; }
        }

        // Constructor
        public Customer()
        {
             balance = new Balance();

        }

        public void Purchase()
        {

        }

        public void SelectGood(string name, int quantity, Storage storage)
        {
            //storage.goods


        }

    }
}
