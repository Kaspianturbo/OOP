using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1._2_Basics_CSharp
{
    static public class TemperatureConvertor
    {
        static public double ToСelsius(double f)
        {
            var res = (f - 32) * 5 / 9;
            return res;
        }
    }
}
