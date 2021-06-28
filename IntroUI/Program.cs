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
        static double FindHighestNumber(double[] listInput)
        {
            double highestNumber = listInput[0];
            foreach (var item in listInput)
            {
                if (item > highestNumber)
                {
                    highestNumber = item;
                }
            }
            return highestNumber;
        }
        static double FindLowestNumber(double[] listInput)
        {
            double lowestNumber = listInput[0];
            foreach (var item in listInput)
            {
                if (item < lowestNumber)
                {
                    lowestNumber = item;
                }
            }
            return lowestNumber;
        }
        static double FindAverageNumber(double[] listInput)
        {
            double totalNumber = 0;
            int totalCount = listInput.Length;
            foreach (var item in listInput)
            {
                totalNumber += item;
            }
            double averageNumber = totalNumber / totalCount;
            return averageNumber;
        }
    }
}