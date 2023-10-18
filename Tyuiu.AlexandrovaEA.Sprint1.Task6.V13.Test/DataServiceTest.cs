using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint1.Task6.V13.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "абвг";
            var res = ds.CheckWordsAlphabet(value);
            Assert.AreEqual(true, res);
        }
    }
}
