using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class LowestNumber : ICalculator
    {
        public double Calculate(double[] numbers)
        {
            double lowestNumber = numbers[0];
            foreach (var item in numbers)
            {
                if (item < lowestNumber)
                {
                    lowestNumber = item;
                }
            }
            return lowestNumber;
        }
    }
}
