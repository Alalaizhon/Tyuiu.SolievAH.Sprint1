using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint1.Task2.V16.Lib;

namespace Tyuiu.SolievAH.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x; 
            x = 2 * Math.PI * 3;
            Assert.AreEqual(18.850, x, 0.001);

            //CalculatePerimetrCircle(int)
        }
    }
}
