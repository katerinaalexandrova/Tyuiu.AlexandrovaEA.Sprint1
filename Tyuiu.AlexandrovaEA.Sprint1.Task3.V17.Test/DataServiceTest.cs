using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ZeroCheck()
        {
            DataService ds = new DataService();
            double number = 2.305;
            var res = ds.ZeroCheck(number);
            Assert.AreEqual(true, res);
        }          
    }
}
