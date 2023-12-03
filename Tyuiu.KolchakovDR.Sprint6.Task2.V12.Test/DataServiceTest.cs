using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint6.Task2.V12.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task2.V12.Test
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
            double[] res = new double[step];
            res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { -2.15, -2.57, -3, -3.83, -11.7, 3, 2.19, 3.31, 2.97, 1.18, 0.03 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
