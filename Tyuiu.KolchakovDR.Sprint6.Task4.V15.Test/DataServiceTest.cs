using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint6.Task4.V15.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task4.V15.Test
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

            double[] wait = { 3.3, -12.37, -14.02, -5.57, 0.65, 0, -0.65, 5.57, 14.02, 12.37, -3.3 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
