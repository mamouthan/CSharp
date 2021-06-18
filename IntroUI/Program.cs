using System;
using System.Collections.Generic;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<double> numbers = new List<double>();
            Console.WriteLine("Please enter list of numbers then enter \" = \" to check highest inputted number: ");
            while (true)
            {            
                string keyboardInput = ValidateNumber();
                if (keyboardInput == "=")
                {
                    break;
                }
                else if (keyboardInput == "Not Number")
                {
                    continue;
                }
                else
                {
                    numbers.Add(Convert.ToDouble(keyboardInput));
                }
            }            
            Console.WriteLine("Please choose output for list of numbers:");
            Console.WriteLine("1. Highest Number");
            Console.WriteLine("2. Lowest Number");
            Console.WriteLine("3. Average Number");
            string choosedOutput = "";
            double outputMethod = 0;  
            while (true)
            {
                string outputType = Convert.ToString(Console.ReadLine());    
                if (outputType == "1")                {
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
                    outputMethod = FindAverageNumber (numbers);
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
        static string ValidateNumber ()
        {
            string keyInput = Convert.ToString(Console.ReadLine());
            Boolean validNumber = double.TryParse(keyInput, out double compareNumber);
            if(!validNumber && keyInput != "=")
            {
                Console.WriteLine("Not a Number, please try again.");
                keyInput = "Not Number";
            }
            return keyInput;
        }

        static double FindHighestNumber (List<double> listInput)
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

        static double FindLowestNumber (List<double> listInput)
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

        static double FindAverageNumber (List<double> listInput)
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
