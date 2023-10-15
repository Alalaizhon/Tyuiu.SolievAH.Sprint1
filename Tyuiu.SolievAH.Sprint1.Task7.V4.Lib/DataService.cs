using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SolievAH.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double a, a1, z;
            a = x - (y / (x + x * x / 4));
            a1 = y - Math.Sqrt(Math.Abs(x));
            z = Math.Log10(Math.Abs(a1 * a));
            return Math.Round(z, 3);
            //−0.247117924 ПРИМЕРНЫЙ ОТВЕТ
        }
    }
}
