using System;
using System.Collections.Generic;

namespace IntroUI
{
    class UserInput
    {
       private double[] numbers;
       private string choosedCalculation;
       public double[] Numbers
       {
           get
           {
               return numbers;
           }
           set
           {
               numbers = value;
           }
       }
       public string ChoosedCalculation
       {
           get
           {
               return choosedCalculation;
           }
           set
           {
               choosedCalculation = value;
           }
       }
    }
}