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
            Dictionary<string, ICalculation> calculationDictionary = new Dictionary<string, ICalculation>
            {
                {"1", new HighestNumber(dataInput.numbers)},
                {"2", new LowestNumber(dataInput.numbers)},
                {"3", new AverageNumber(dataInput.numbers)}
            };
            ICalculation calculation = calculationDictionary[dataInput.choosedCalculation];
            calculation.Calculate();
        }        
    }
}
