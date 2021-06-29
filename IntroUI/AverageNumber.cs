using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class AverageNumber : ICalculator
    {
        public void Calculate(in double[] listNumbers, out double resultCalculation)
        {
            double totalNumber = 0;
            int totalCount = listNumbers.Length;
            foreach (var item in listNumbers)
            {
                totalNumber += item;
            }
            resultCalculation = totalNumber / totalCount;
        }
    }
}
