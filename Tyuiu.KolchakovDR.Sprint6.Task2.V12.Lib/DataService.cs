using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolchakovDR.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int step = (stopValue - startValue) + 1;
            double[] res = new double[step];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                res[count] = (2 * x + 6) / (Math.Cos(x) + x) - 3;
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
