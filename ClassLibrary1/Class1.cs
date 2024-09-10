using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public static double thetich(double a, double b, double h)
        {
            return Math.PI*(a*a + b*b + a*b)*h/3;
        }
    }
}
