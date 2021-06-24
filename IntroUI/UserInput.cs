using System;
using System.Collections.Generic;

namespace IntroUI
{
    class UserInput
    {
        private double[] numbers;
        private string choosedCalculation;
        private bool validNumber;
        public UserInput()
        {
            GetInputKeyboard();
            GetSelectionCalculation();
        }
        public double[] Numbers
        {
            get
            {
                return this.numbers;
            }
            set
            {
                this.numbers = value; 
            }
        }
        public string ChoosedCalculation
        {
            get
            {
                return this.choosedCalculation;
            }
            set
            {
                this.choosedCalculation = value;
            }
        }
        private void GetInputKeyboard()
        {
            Console.WriteLine("Please input numbers then enter \" = \" when done: ");
            List<double> listNumbers = new List<double>();
            while (true)
            {
                string keyboardInput = Console.ReadLine();
                this.validNumber = double.TryParse(keyboardInput, out double compareNumber);
                if (!this.validNumber && keyboardInput != "=")
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
            Numbers = listNumbers.ToArray();
        }
        private void GetSelectionCalculation()
        {
            Console.WriteLine("Please choose output for numbers input:");
            Console.WriteLine("1. Highest Number");
            Console.WriteLine("2. Lowest Number");
            Console.WriteLine("3. Average Number");
            while (true)
            {
                string keyboardInput = Console.ReadLine();
                if (keyboardInput == "1" || keyboardInput == "2" || keyboardInput == "3")
                {
                    ChoosedCalculation = keyboardInput;
                    break;
                }
                else
                {
                    Console.WriteLine(" You choosed wrong method, please choose again 1, 2 or 3");
                }
            }
        }
    }
}
