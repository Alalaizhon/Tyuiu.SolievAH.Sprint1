using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SolievAH.Sprint1.Task0.V25.Lib;

namespace Tyuiu.SolievAH.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
