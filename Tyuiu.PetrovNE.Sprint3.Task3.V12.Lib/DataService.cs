using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovNE.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0, MaxCount = 0;

            foreach (char c in value) 
            {
                if (c == item)
                {
                    count++;
                }
                else
                {
                    MaxCount = Math.Max(MaxCount, count);
                    count = 0;
                }
            }

            return MaxCount;
        }
    }
}
