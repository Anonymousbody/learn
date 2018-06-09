using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逻辑
{
    public class Calculator
    {
        public delegate double Calc(double x);
        public double PF(double x)
        {
            return x * x;
        }
        public double CF(double x)
        {
            return x * x * x;
        }
        public static double[] Apply(ref double[] a, Calc f)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
                result[i] = f(a[i]);
            return result;
        }



    }
}
