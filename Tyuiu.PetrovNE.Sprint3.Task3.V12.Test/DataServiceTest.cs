using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint3.Task3.V12.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string MyStr = "bkkrk ckkkcs ksr";
            char MyChar = 'k';
            int wait = 3;
            Assert.AreEqual(wait, ds.GetMaxCharCount(MyStr, MyChar));

        }
    }
}
