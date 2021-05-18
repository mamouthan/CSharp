using System;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; 
            for (int i = 0; i < 5; i++)
            {
                bool validNumber = false; 
                int compareNumber;
                string keyboardInput = "";
                while(validNumber == false)
                { 
                    Console.Write("Please Enter a number: ");
                    keyboardInput = Convert.ToString(Console.ReadLine()); 
                    if(int.TryParse(keyboardInput, out compareNumber))
                    { 
                        validNumber = true;
                    } 
                    else
                    { 
                        Console.WriteLine("Not a Number, please try again.");
                    } 
                }
                numbers[i] = Convert.ToInt32(keyboardInput);
            }

            int highestNumber = numbers[0];
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
