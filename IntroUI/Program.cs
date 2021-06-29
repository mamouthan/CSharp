using System;
using System.Collections.Generic;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputHelper getDataInput = new UserInputHelper();
            UserInput dataInput = getDataInput.GetInputKeyboard();
            Dictionary<string, ICalculator> calculationDictionary = new Dictionary<string, ICalculator>
            {
                {"1", new HighestNumber()},
                {"2", new LowestNumber()},
                {"3", new AverageNumber()}
            };
            ICalculator calculation = calculationDictionary[dataInput.choosedCalculation];
            calculation.Calculate(in dataInput.numbers, out double ResultCalculation);
            Console.WriteLine("The result is {0}", ResultCalculation);
        }
    }
}