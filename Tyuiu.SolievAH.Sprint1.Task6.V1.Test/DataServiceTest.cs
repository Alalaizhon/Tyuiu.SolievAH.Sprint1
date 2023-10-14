using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint1.Task6.V1.Lib;

namespace Tyuiu.SolievAH.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.SymbolCode("2");

            Assert.AreEqual("2 50", res);
        }
    }
}
