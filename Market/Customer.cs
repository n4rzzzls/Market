using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Customer
    {
        private double balance_min = 100;
        private double balance_max = 1000;
        private double balance_cash;
        private double balance_card;

        public double Balance_cash
        {
            set { balance_cash = value; }
            get { return balance_cash; }
        }
        public double Balance_card
        {
            set { balance_card = value; }
            get { return balance_card; }
        }

        public Customer()
        {
            Random random = new Random();
            balance_card = (random.NextDouble() * (balance_max - balance_min) + balance_min);
            balance_cash = (random.NextDouble() * (balance_max - balance_min) + balance_min);

        }

        public void Purchase()
        {

        }

        public void SelectGood()
        {


        }

    }
}
