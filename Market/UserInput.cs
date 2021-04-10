using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class UserInput
    {

        private ConsoleKeyInfo pressed_key;
        private int pressed_key_int = 0;
        

        public bool PressedKeyIsDigitValidation()
        {
            bool isDigit;

            while (true)
            {
                pressed_key = Console.ReadKey();

                if (char.IsDigit(pressed_key.KeyChar))
                {
                    isDigit = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Digit should be entered!");
                }
                
            }

            return isDigit;
        }


        public int ConsoleKeyInfoToInt()
        {
            while (pressed_key_int != 1)
            {
                pressed_key = Console.ReadKey();

                if (char.IsDigit(pressed_key.KeyChar))
                {
                    pressed_key_int = int.Parse(pressed_key.KeyChar.ToString()); // use Parse if it's a Digit

                    if (pressed_key_int != 1)
                    {
                        Console.WriteLine("Incorrect key!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect key!");
                }
            }


            return 0;
        }
    }
}
