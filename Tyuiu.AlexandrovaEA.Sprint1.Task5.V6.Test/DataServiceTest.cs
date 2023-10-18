using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n, k = 1;
            var res = ds.Calculate(k);
            Assert.AreEqual(1, res);
        }
    }
}
