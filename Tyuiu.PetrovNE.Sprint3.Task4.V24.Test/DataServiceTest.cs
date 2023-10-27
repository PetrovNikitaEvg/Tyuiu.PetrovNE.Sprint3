using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint3.Task4.V24.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int StartValue = -5, StopValue = 5;
            double wait = 46.75;
            Assert.AreEqual(wait, ds.Calculate(StartValue, StopValue));
        }
    }
}
