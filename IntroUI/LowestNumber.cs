using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class LowestNumber : ICalculator
    {
        public void Calculate(in double[] listNumbers, out double resultCalculation)
        {
            double lowestNumber = listNumbers[0];
            foreach (var item in listNumbers)
            {
                if (item < lowestNumber)
                {
                    lowestNumber = item;
                }
            }
            resultCalculation = lowestNumber;
        }
    }
}
