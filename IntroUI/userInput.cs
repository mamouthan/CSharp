using System;
using System.Collections.Generic;

namespace IntroUI
{
    class UserInput
    {
        public double[] numbers;
        public string choosedCalculation;
        public double[] GetKeyboardInput()
        {
            Console.WriteLine("Please input numbers then enter \" = \" when done: ");
            List<double> listNumbers = new List<double>();
            while (true)
            {
                string keyboardInput = Console.ReadLine();
                Boolean validNumber = double.TryParse(keyboardInput, out double compareNumber);
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
            numbers = listNumbers.ToArray();
            return numbers;
        }
        public string GetSelectionCalculation()
        {
            Console.WriteLine("Please choose output for numbers input:");
            Console.WriteLine("1. Highest Number");
            Console.WriteLine("2. Lowest Number");
            Console.WriteLine("3. Average Number");
            while (true)
            {
                string outputType = Console.ReadLine();
                if (outputType == "1" || outputType == "2" || outputType == "3")
                {
                    choosedCalculation = outputType;
                    break;
                }
                else
                {
                    Console.WriteLine(" You choosed wrong method, please choose again 1, 2 or 3");
                }
            }
            return choosedCalculation;
        }
    }
}
