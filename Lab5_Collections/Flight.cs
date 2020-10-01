using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Collections
{
    public class Flight
    {
        public string T { get; }
        public int R { get; }
        public int K { get; }
        public double Z { get; }
        public double S { get; private set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t">Type</param>
        /// <param name="r">Number of flight</param>
        /// <param name="k">Passengers count</param>
        /// <param name="z">Cost per flight</param>
        public Flight(string t, int r, int k, double z)
        {
            this.T = t;
            this.R = r;
            this.K = k;
            this.Z = z;
        }
        public void AccountS() => S = Z / K;
    }
}
