using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    interface ICalculation
    {
        //property to store calculation result
        double ResultCalculation { get; set; }
        //property to store list of numbers
        double[] ListNumbers { get; set; }
        void Calculate(); 
    }
}
