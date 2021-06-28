using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class HighestNumber : ICalculation
    {
        public double ResultCalculation { get; set; }
        public double[] ListNumbers { get; set; }

        public HighestNumber(double[] numbers)
        {
            ListNumbers = numbers;
        }
        public void Calculate()
        {
            double highestNumber = ListNumbers[0];
            foreach (var item in ListNumbers)
            {
                if (item > highestNumber)
                {
                    highestNumber = item;
                }
            }
            ResultCalculation = highestNumber;
            Console.WriteLine("The result is {0}", ResultCalculation);
        }
    }
}
