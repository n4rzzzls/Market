using System;
using System.Data;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Market!\n\nSelect one of the options below:\n");
            Console.WriteLine("\t1.Enter Marker.\n\t2.Display available goods.\n\t3.Add good to the cart.\n\t4.Remove good from the cart.");
            Console.WriteLine("\t5.Purchase added to cart goods.\n\t6.Leave market");
            Customer customer = new Customer();

            Storage storage = new Storage();

            storage.DisplayGoods();





            //Console.WriteLine(customer.Balance.Balance_card);
            Console.ReadKey();

        }
    }
}
