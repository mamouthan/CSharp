using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class UserInputHelper
    {
        public UserInput GetInputKeyboard()
        {
            UserInput getUserInput = new UserInput();
            Console.WriteLine("Please input numbers then enter \" = \" when done: ");
            List<double> listNumbers = new List<double>();
            while (true)
            {
                string keyboardInput = Console.ReadLine();
                bool validNumber = double.TryParse(keyboardInput, out double compareNumber);
                if (!validNumber && keyboardInput != "=")
                {
                    Console.WriteLine("Not a Number, please try again.");
                    continue;
                }
                if (keyboardInput == "=")
                {
                    break;
                }
                else
                {
                    listNumbers.Add(Convert.ToDouble(keyboardInput));
                }
            }
            getUserInput.numbers = listNumbers.ToArray();
            Console.WriteLine("Please choose output for numbers input:");
            Console.WriteLine("1. Highest Number");
            Console.WriteLine("2. Lowest Number");
            Console.WriteLine("3. Average Number");
            while (true)
            {
                string keyboardInput = Console.ReadLine();
                if (keyboardInput == "1" || keyboardInput == "2" || keyboardInput == "3")
                {
                    getUserInput.choosedCalculation = keyboardInput;
                    break;
                }
                else
                {
                    Console.WriteLine(" You choosed wrong method, please choose again 1, 2 or 3");
                }
            }
            return getUserInput;
        }
    }
}
