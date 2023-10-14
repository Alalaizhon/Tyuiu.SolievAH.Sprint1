using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint1.Task1.V27.Lib;

namespace Tyuiu.SolievAH.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2,2);

            Assert.AreEqual(2, res);
        }
    }
}
