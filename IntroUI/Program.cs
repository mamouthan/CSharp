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
            string keyboardInput = "";
            while (true)
            {
                keyboardInput = numberValidation(Convert.ToString(Console.ReadLine()));
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
                    outputMethod = highest(numbers);
                    break;
                }
                else if (outputType == "2")
                {
                    choosedOutput = "lowest number";
                    outputMethod = lowest(numbers);
                    break;
                }
                else if (outputType == "3")
                {
                    choosedOutput = "average number";
                    outputMethod = average(numbers);
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
        static string numberValidation ( string keyInput)
        {
            if(double.TryParse(keyInput, out double compareNumber) || keyInput == "=")
            {
            }
            else
            {
                Console.WriteLine("Not a Number, please try again.");
                keyInput = "Not Number";
            }
            return keyInput;
        }

        static double highest (List<double> listInput)
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

        static double lowest (List<double> listInput)
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

        static double average (List<double> listInput)
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
