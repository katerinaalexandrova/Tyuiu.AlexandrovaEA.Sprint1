using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint1.Task7.V18.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DatServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.609, res);
        }
    }
}
