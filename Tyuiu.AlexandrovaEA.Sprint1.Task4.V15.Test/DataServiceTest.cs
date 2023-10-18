using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint1.Task4.V15.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(7.388, res);
        }
    }
}
