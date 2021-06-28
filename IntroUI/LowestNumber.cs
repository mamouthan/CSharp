using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class LowestNumber : ICalculation
    {
        public double ResultCalculation { get; set; }
        public double[] ListNumbers { get; set; }

        public LowestNumber(double[] numbers)
        {
            ListNumbers = numbers;
        }
        public void Calculate()
        {
            double lowestNumber = ListNumbers[0];
            foreach (var item in ListNumbers)
            {
                if (item < lowestNumber)
                {
                    lowestNumber = item;
                }
            }
            ResultCalculation = lowestNumber;
            Console.WriteLine("The result is {0}", ResultCalculation);
        }
    }
}
