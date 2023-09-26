using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint1.Task3.V6.Lib;

namespace Tyuiu.ModenovaAP.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 67;
            double y = 8.5;
            double a = 6.5;
            double wait = 74.035;
            var res = ds.TravelCost(x, y, a);
            Assert.AreEqual(wait, res);
        }
    }
}
