using System;
using System.Collections.Generic;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Please input numbers then enter \" = \" when done: ");
            List<double> numbers = GetNumberInput();
            
            Console.WriteLine("Please choose output for extracted numbers from keyboard input:");
            Console.WriteLine("1. Highest Number");
            Console.WriteLine("2. Lowest Number");
            Console.WriteLine("3. Average Number");
            string choosedOutput = "";
            double outputMethod = 0;
            while (true)
            {
                string outputType = Console.ReadLine();
                if (outputType == "1")
                {
                    choosedOutput = "highest number";
                    outputMethod = FindHighestNumber(numbers);
                    break;
                }
                else if (outputType == "2")
                {
                    choosedOutput = "lowest number";
                    outputMethod = FindLowestNumber(numbers);
                    break;
                }
                else if (outputType == "3")
                {
                    choosedOutput = "average number";
                    outputMethod = FindAverageNumber(numbers);
                    break;
                }
                else
                {
                    Console.WriteLine(" You choosed wrong method, please choose again 1, 2 or 3");
                }
            }
            Console.WriteLine("===========================");
            Console.WriteLine("The " + choosedOutput + " is " + outputMethod);
        }
        static List<double> GetNumberInput()
        {
            List<double> numbers = new List<double>();
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
                    numbers.Add(Convert.ToDouble(keyboardInput));
                }
            }
            return numbers;
        }
        static double FindHighestNumber(List<double> listInput)
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
        static double FindLowestNumber(List<double> listInput)
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
        static double FindAverageNumber(List<double> listInput)
        {
            double totalNumber = 0;
            int totalCount = listInput.Count;
            foreach (var item in listInput)
            {
                totalNumber += item;
            }
            double averageNumber = totalNumber/totalCount;
            return averageNumber;
        }
    }
}
