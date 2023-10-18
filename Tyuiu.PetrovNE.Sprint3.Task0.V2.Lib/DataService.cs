using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovNE.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1;
            for (int k = startValue; k <= stopValue; k++) 
            {
                result *= Math.Pow( ( (k) / ( Math.Pow((Math.Sin(1)), -7) ) ), -2 );
               //            pow         chisl         znam                  pow to    
            }
            return result;
        }
    }
}
