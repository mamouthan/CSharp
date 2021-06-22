using System;
using System.Collections.Generic;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Please input numbers then enter \" = \" when done: ");
            Tuple<double[],string> userInput = GetKeyboardInput();
            double[] numbers = userInput.Item1;
            string choosedOutput = userInput.Item2;
            double outputMethod = 0;
            if (choosedOutput == "1")
            {
                choosedOutput = "highest number";
                outputMethod = FindHighestNumber(numbers);
            }
            else if (choosedOutput == "2")
            {
                choosedOutput = "lowest number";
                outputMethod = FindLowestNumber(numbers);
            }
            else if (choosedOutput == "3")
            {
                choosedOutput = "average number";
                outputMethod = FindAverageNumber(numbers);
            }

            Console.WriteLine("===========================");
            Console.WriteLine("The " + choosedOutput + " is " + outputMethod);
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
            double averageNumber = totalNumber/totalCount;
            return averageNumber;
        }
        static Tuple<double[], string> GetKeyboardInput()
        {
            List<double> listNumbers = new List<double>();
            while (true)
            {
                string keyboardInput = Console.ReadLine();
                Boolean validNumber = double.TryParse(keyboardInput, out double compareNumber);
                if(!validNumber && keyboardInput != "=")
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
            double[] numbers = listNumbers.ToArray();

            Console.WriteLine("Please choose output for numbers input:");
            Console.WriteLine("1. Highest Number");
            Console.WriteLine("2. Lowest Number");
            Console.WriteLine("3. Average Number");
            string choosedMethod = "";
            while (true)
            {
                string outputType = Console.ReadLine();
                if (outputType == "1" || outputType == "2" || outputType == "3")
                {
                    choosedMethod = outputType;
                    break;
                }
                else
                {
                    Console.WriteLine(" You choosed wrong method, please choose again 1, 2 or 3");
                }
            }
            return Tuple.Create(numbers, choosedMethod);
        }
    }
}
