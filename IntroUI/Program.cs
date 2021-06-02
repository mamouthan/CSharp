using System;
using System.Collections.Generic;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<double> temporaryNumbers = new List<double>();
            Console.WriteLine("Please enter list of numbers then enter \" = \" to check highest inputted number: ");
            while (true)
            {
                string keyboardInput = "";  
                Boolean finishInput = false;              
                while(true)
                { 
                    double compareNumber;
                    keyboardInput = Convert.ToString(Console.ReadLine());
                    if(double.TryParse(keyboardInput, out compareNumber))
                    { 
                        break;
                    }
                    else if (keyboardInput == "=")
                    {
                        finishInput = true;
                        break;
                    }
                    else
                    { 
                        Console.WriteLine("Not a Number, please try again.");
                    } 
                }
                if (finishInput)
                {
                    break;
                }
                temporaryNumbers.Add(Convert.ToDouble(keyboardInput));
            }
            double[] numbers = temporaryNumbers.ToArray();
            double highestNumber = numbers[0];
            
            foreach (var item in numbers)
            {
                if (item > highestNumber)
                {
                    highestNumber = item;
                }                
            }            
            Console.WriteLine("===========================");
            Console.WriteLine("The highest number is " + highestNumber);
        }
    }
}
