using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint1.Task7.V4.Lib;

namespace Tyuiu.SolievAH.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2, 2);
            Assert.AreEqual(-0.107, res);
                
        }
    }
}
