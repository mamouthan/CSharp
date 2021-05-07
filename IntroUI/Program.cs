using System;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int highest = 0;
            int times;
            Console.WriteLine("Enter how many number(s) user want to enter: ");
            times = Convert.ToInt32(Console.ReadLine());
            
            int[] nums = new int[times];
           
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Please Enter a number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in nums)
            {
                int temp = item;
                if (temp > highest)
                {
                    highest = temp;
                }                
            }
            Console.WriteLine("===========================");
            Console.WriteLine("The highest number is " + highest);
        }
    }
}
