using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint3.Task6.V12.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = 9, stopValue = 18, wait = 221;
            Assert.AreEqual(ds.GetSumTheDivisors(startValue, stopValue), wait);
        }
    }
}
