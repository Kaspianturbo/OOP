using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Basics_OOP
{
    public class Flight
    {
        private string t;
        private int r, k;
        private double z, s = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t">Type</param>
        /// <param name="r">Number of flight</param>
        /// <param name="k">Passengers count</param>
        /// <param name="z">Cost per flight</param>
        public Flight(string t, int r, int k, double z)
        {
            this.t = t;
            this.r = r;
            this.k = k;
            this.z = z;
        }
        public void AccountS() => s = z / k;
        public string GetT() => t;
        public int GetR() => r;
        public int GetK() => k;
        public double GetZ() => z;
        public double GetS() => s;
    }
}
