using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint3.Task5.V23.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds  = new DataService();
            int x = 2, startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 10;
            double wait = -3653.176;
            Assert.AreEqual(wait, ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}
