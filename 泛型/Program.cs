using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 逻辑;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] a = new double[5] { 5, 7, 9, 11, 15 };
            Calculator calculator = new Calculator();
            Calculator.Calc calc;
            calc = new Calculator.Calc(calculator.PF);
            double[] c=Calculator.Apply(ref a, calc);
            foreach (double b in a)
                Console.Write("{0} ", b);
            foreach (double b in c)
                Console.Write("{0} ", b);
            Console.Read();
        }
    }
}
