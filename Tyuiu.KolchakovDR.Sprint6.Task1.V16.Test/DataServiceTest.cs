using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint6.Task1.V16.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int step = (stopValue - startValue) + 1;

            double[] wait = { -12.18, 16.03, 18.87, 4.96, -9.99, -2, 2.16, -7.54, -22.76, -20.45, 7.77 };
            double[] res = new double[step];

            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
