using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class HighestNumber : ICalculator
    {
        public void Calculate(in double[] listNumbers, out double resultCalculation)
        {
            double highestNumber = listNumbers[0];
            foreach (var item in listNumbers)
            {
                if (item > highestNumber)
                {
                    highestNumber = item;
                }
            }
            resultCalculation = highestNumber;
        }
    }
}
