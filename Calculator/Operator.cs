using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operator
    {
        public static double Add(double n1, double n2) => n1 + n2;
        public static double Sub(double n1, double n2) => n1 - Math.Abs(n2);
        
        public static double Times(double n1, double n2) => n1 * n2;
        public static double Div(double n1, double n2) => n1 / n2;
        public static double Sqrt(double n1) => Math.Sqrt(n1);
        public static double PowToTwo(double n1) => Math.Pow(n1, 2);
        public static double OneDivX(double n1) => 1 / n1;
    }
}
