using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._6
{
    public static class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Pow(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
        public static int Rest(int a, int b)
        {
            return a % b;
        }
    }
}
