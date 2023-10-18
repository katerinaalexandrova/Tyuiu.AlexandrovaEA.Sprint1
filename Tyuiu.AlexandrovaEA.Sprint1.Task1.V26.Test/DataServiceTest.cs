using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint1.Task1.V26.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}
