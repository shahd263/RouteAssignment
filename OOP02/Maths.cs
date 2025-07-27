using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Maths
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public static double Sum (double Num1, double Num2)
        {
            return Num1 + Num2;
        }
        public static double Subtract (double Num1, double Num2)
        { 
                return Num1 - Num2; 
        }

        public static double Multiply (double Num1, double Num2)
        {
            return Num1 * Num2;
        }

        public static double Division(double Num1, double Num2)
        {
            return Num1 / Num2;
        }








    }
}
