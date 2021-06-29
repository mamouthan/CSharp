using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    interface ICalculator
    {
        void Calculate(in double[] listNumbers, out double resultCalculation);
    }
}
