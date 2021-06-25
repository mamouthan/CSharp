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
            Dictionary<string, Func<double[], double>> calculationDictionary = new Dictionary<string, Func<double[], double>>
            {
                {"1", FindHighestNumber},
                {"2", FindLowestNumber},
                {"3", FindAverageNumber}
            };
            double resultCalculation = calculationDictionary[dataInput.choosedCalculation](dataInput.numbers);
            Console.WriteLine("The result is {0}", resultCalculation);
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
