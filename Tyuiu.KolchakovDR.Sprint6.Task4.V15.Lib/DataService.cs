using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolchakovDR.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int step = (stopValue - startValue) + 1;
            double[] res = new double[step];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                res[count] = Math.Sin(x) + 2.0 * x / 3.0 - Math.Cos(x) * 4.0 * x;
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
