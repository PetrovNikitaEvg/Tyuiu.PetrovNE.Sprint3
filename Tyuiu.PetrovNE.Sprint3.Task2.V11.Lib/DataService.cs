﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovNE.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res += Math.Pow( (1 / (3 + (Math.Pow(value, startValue)) ) ), startValue);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
