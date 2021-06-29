using System;
using System.Collections.Generic;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputHelper userInputHelper = new UserInputHelper();
            UserInput userInput = userInputHelper.GetInputKeyboard();
            Dictionary<string, ICalculator> calculationDictionary = new Dictionary<string, ICalculator>
            {
                {"1", new HighestNumber()},
                {"2", new LowestNumber()},
                {"3", new AverageNumber()}
            };
            ICalculator calculator = calculationDictionary[userInput.choosedCalculation];
            Console.WriteLine("The result is {0}", calculator.Calculate(userInput.numbers));
        }
    }
}