using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint1.Task2.V28.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataSetviceTest
    {
        [TestMethod]
            public void ConvertCelsiusToKelvin()
            {
                DataService ds = new DataService();
                int value=2;
                var res = ds.ConvertCelsiusToKelvin(value);
                Assert.AreEqual(275, res);
            }

    }
}
