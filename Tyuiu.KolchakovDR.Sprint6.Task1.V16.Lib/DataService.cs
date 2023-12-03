using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolchakovDR.Sprint6.Task1.V16.Lib
{
    public class DataService : ISprint6Task1V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int step = (stopValue - startValue) + 1;
            double[] res = new double[step];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                res[count] = Math.Sin(x) / (x + 1.2) + Math.Cos(x) * (7 * x) - 2;
                res[count] = Math.Round(res[count], 2);

                if (double.IsNaN(res[count]))
                {
                    res[count] = 0;
                }
                count++;
            }
            return res;
        }
    }
}
