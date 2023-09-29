using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint1.Task7.V18.Lib;

namespace Tyuiu.ModenovaAP.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 1;
            double wait = -0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
