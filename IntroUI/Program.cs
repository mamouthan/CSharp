using System;
using System.Collections.Generic;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Please input anything from keyboard then enter \" = \" when done: ");
            List<string> listKeyboardInput = GetKeyboardInput();
            List<double> numbers = GetNumberOnly(listKeyboardInput);

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
        static List<string> GetKeyboardInput()
        {
            List<string> listKeyboardInput = new List<string>();
            while (true)
            {
            string keyInput = Console.ReadLine();
            listKeyboardInput.Add(keyInput);
                if (keyInput == "=")
                {
                    break;
                }
            }
            return listKeyboardInput;
        }
        static List<double> GetNumberOnly(List<string> listInput)
        {
            List<double> numbers= new List<double>();
            foreach (var item in listInput)
            {
                Boolean validNumber = double.TryParse(item, out double compareNumber);
                if(validNumber)
                {
                    numbers.Add(Convert.ToDouble(item));
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
