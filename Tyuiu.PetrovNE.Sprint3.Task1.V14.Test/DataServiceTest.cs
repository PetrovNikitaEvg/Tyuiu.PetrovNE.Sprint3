using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint3.Task1.V14.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double value = 0.7; int startValue = 1; int stopValue = 14;
            double wait = 14.967;
            Assert.AreEqual(wait, ds.GetSumSeries(value, startValue, stopValue));

        }
    }
}
