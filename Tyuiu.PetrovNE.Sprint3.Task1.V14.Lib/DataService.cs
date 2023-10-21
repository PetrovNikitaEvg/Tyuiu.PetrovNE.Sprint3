using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovNE.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0, k = startValue;
            while (k <= stopValue)
            {
                res += ( Math.Pow(value, k) + ( 1 / k + 1 ) ) * Math.Cos(value);
                k++;
            }
            return Math.Round(res, 3);
        }
    }
}
