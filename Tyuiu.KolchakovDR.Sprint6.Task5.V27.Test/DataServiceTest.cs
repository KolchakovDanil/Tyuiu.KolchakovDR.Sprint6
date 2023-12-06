using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint6.Task5.V27.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask5V27.txt";

            double[] res = ds.LoadFromDataFile(path);

            double[] wait = { -17, 12, -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, -9, 13.83, 12.76, 8.86, -1.49, -7 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
