using System;
using System.Data;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Storage storage = new Storage();

            storage.GetGoods();

            Console.WriteLine(customer.Balance.Balance_card);
            Console.ReadKey();
        }
    }
}
