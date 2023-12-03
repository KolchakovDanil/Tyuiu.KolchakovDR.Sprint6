using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolchakovDR.Sprint6.Task0.V15.Lib
{
    public class DataService : ISprint6Task0V15
    {
        public double Calculate(int x)
        {
            double res = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            return Math.Round(res, 3);
        }
    }
}
