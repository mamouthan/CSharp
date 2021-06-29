using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class AverageNumber : ICalculator
    {
        public double Calculate(double[] numbers)
        {
            double totalNumber = 0;
            int totalCount = numbers.Length;
            foreach (var item in numbers)
            {
                totalNumber += item;
            }
            return totalNumber / totalCount;
        }
    }
}
