using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint6.Task7.V21.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V21.csv";
            int[,] res = ds.GetMatrix(path);

            int[,] wait = {
                { -4, -2, 13, -12, 12, -19, 5, -1, -6, -12 },
                { 19, 2, -3, 1, -9, -10, 6, -1, -5, -5 },
                { -14, 13, 2, 8, -12, 3, -5, -1, 1, -4 },
                { -6, -13, 3, 19, -10, 9, 2, -1, 4, 16 },
                { -14, -12, 1, 5, 14, 3, -7, -1, -19, -12 },
                { -13, -1, -1, 14, 11, -1, 4, -1, 1, -4 },
                { -11, 7, 2, 3, -12, -19, -12, -1, 15,  5 },
                { 4, 20, -4, -10, 8, -16, -14, -1, -7, 6 },
                { -19, -5, -9, -19, 2, -2, 7, -1, -6, 14 },
                { -4, 13, 4, 8, -19, -18, 19, -1, -20, -12 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
