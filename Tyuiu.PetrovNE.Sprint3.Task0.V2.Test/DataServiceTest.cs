using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint3.Task0.V2.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int Start = 1, End = 9;
            double wait = 0.021;
            Assert.AreEqual(wait, ds.GetMultiplySeries(Start, End));
        }
    }
}
