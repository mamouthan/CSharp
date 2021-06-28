using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class AverageNumber : ICalculation
    {
        public double ResultCalculation { get; set; }
        public double[] ListNumbers { get; set; }

        public AverageNumber(double[] numbers)
        {
            ListNumbers = numbers;
        }
        public void Calculate()
        {
            double totalNumber = 0;
            int totalCount = ListNumbers.Length;
            foreach (var item in ListNumbers)
            {
                totalNumber += item;
            }
            ResultCalculation = totalNumber / totalCount;
            Console.WriteLine("The result is {0}", ResultCalculation);
        }
    }
}
