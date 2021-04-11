using System;
using System.Data;
using System.Text;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            // Variables
            UserInput userInput = new UserInput();
            Customer customer;
            Storage storage = new Storage();
            int pressed_key_int;
            int selected_good_id;
            int quantity;

            
            Console.WriteLine("1.Enter Marker.");

            while (true)
            {

                if (userInput.PressedKey() == 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nIncorrect key!");
                }

            }


        label_customer:
            customer = new Customer();

            // Some console output
            Console.WriteLine("---\nWelcome to the Market!\n\nSelect one of the options below:\n");
            Console.WriteLine("\t1.Display available goods.\n\t2.Add good to the cart.\n\t3.Remove good from the cart.");
            Console.WriteLine("\t4.Purchase added to cart goods.\n\t5.Leave market");

        label_here:
            pressed_key_int = userInput.PressedKey();


            // Switch/case

            switch (pressed_key_int)
            {
                case 1:
                    storage.DisplayGoods();
                    goto label_here;

                case 2:
                    Console.WriteLine("Enter ID of good: ");
                    selected_good_id = userInput.PressedKey();
                    Console.WriteLine("Enter quantity: ");
                    quantity = userInput.PressedKey();
                    customer.SelectGood(selected_good_id, quantity);
                    goto label_here;

                case 3:
                    Console.WriteLine("Enter ID of a good to be removed ftom the cart: ");
                    selected_good_id = userInput.PressedKey();
                    Console.WriteLine("Enter quantity of a goods to be removed from a cart: ");
                    quantity = userInput.PressedKey();
                    customer.RemoveGood(selected_good_id, quantity);
                    goto label_here;

                case 4:
                    customer.Purchase();
                    goto label_here;

                case 5:
                    goto label_customer;

                default:
                    Console.WriteLine("\nIncorrect key!");
                    goto label_here;

            }


            //storage.DisplayGoods();





            //Console.WriteLine(customer.Balance.Balance_card);
            Console.ReadKey();

        }
    }
}
