﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint1.Task6.V5.Lib;

namespace Tyuiu.ModenovaAP.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "шалаш";
            string[] xs = x.Split(' ');
            for (int i = 0; i < xs.Length; i++)
            {
                string res1 = ds.CheckSymmetricalWords(xs[i]);
                string result = "шалаш";
                Assert.AreEqual(result, res1);
            }
        }
    }
}
