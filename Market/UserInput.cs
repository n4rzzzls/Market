using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class UserInput
    {
        // Checks that pressed key is digit
        public bool PressedKeyIsDigitValidation(ConsoleKeyInfo pressed_key)
        {
            bool isDigit = false;

            if (char.IsDigit(pressed_key.KeyChar))
            {
                isDigit = true;
            }
            else
            {
                Console.WriteLine("\nDigit should be entered!");
            }
                
            return isDigit;
        }


        // Converts ConsoleKeyInfo to int type
        public int ConsoleKeyInfoToInt(ConsoleKeyInfo pressed_key)
        {

            int pressed_key_int = int.Parse(pressed_key.KeyChar.ToString());

            return pressed_key_int;
        }


        // Will check if pressed key is digit and will return pressed key in int type
        public int PressedKey()
        {
            ConsoleKeyInfo pressed_key;
            int pressed_key_int;

            while (true)
            {
                pressed_key = Console.ReadKey();

                if (PressedKeyIsDigitValidation(pressed_key))
                {
                    pressed_key_int = ConsoleKeyInfoToInt(pressed_key);
                    break;
                }
            }
            return pressed_key_int;
        }
    }
}
