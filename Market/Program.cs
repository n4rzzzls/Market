using System;
using System.Data;
using System.Text;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables
            object pressed_key;
            Customer customer;
            Storage storage = new Storage();


            Console.WriteLine("1.Enter Marker.");
            pressed_key = Console.ReadKey();
            // TO DO

            customer = new Customer();

            // Some console output
            Console.WriteLine("Welcome to the Market!\n\nSelect one of the options below:\n");
            Console.WriteLine("\t1.Display available goods.\n\t2.Add good to the cart.\n\t3.Remove good from the cart.");
            Console.WriteLine("\t4.Purchase added to cart goods.\n\t5.Leave market");


            // User input. Verifies that entered variable is int type.
            while (true)
            {
                pressed_key = Console.Read();
                if (pressed_key.GetType() == typeof(int))
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("A number should be selected.");
                }
            }


            // Switch/case
            switch (pressed_key)
            {
                case 1:
                    storage.DisplayGoods();
                    break;

                case 2:

                    Console.WriteLine("Select proper good to be added into cart.\nEnter ID of good: ");
                    int selected_good = Console.Read();

                    //customer.SelectGood()
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

            }


            //storage.DisplayGoods();





            //Console.WriteLine(customer.Balance.Balance_card);
            Console.ReadKey();

        }
    }
}
