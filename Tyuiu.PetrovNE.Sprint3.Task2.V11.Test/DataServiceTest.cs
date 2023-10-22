using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint3.Task2.V11.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double value = 0.5, wait = 0.430; int startValue = 1; int stopValue = 15;
            Assert.AreEqual(wait, ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
