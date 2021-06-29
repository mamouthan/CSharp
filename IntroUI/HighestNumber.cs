using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class HighestNumber : ICalculator
    {
        public double Calculate(double[] numbers)
        {
            double highestNumber = numbers[0];
            foreach (var item in numbers)
            {
                if (item > highestNumber)
                {
                    highestNumber = item;
                }
            }
            return highestNumber;
        }
    }
}
