using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3._1_Reusing_classes
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
        public void ToConsole()
        {
            Console.WriteLine($"" +
                $"Type: {GetT()}\n" +
                $"Number of flight: {GetR()}\n" +
                $"Passengers count: {GetK()}\n" +
                $"Cost per flight: {GetZ()}\n" +
                $"Cost pey person: {GetS()}\n");
        }
    }
    public class Flights
    {
        public List<Flight> Items;
  
        public void ToConsole()
        {
            foreach (Flight flight in Items)
            {
                flight.AccountS();
                flight.ToConsole();
            }
        }
        public void TotalToConsole()
        {
            var totalCost = 0d;
            var totalPassengers = 0;
            var totalFlights = 0;
            foreach (Flight flight in Items)
            {
                totalCost += flight.GetZ();
                totalPassengers += flight.GetK();
                totalFlights++;
            }

            Console.WriteLine($"Total flights: {totalFlights}\n" +
                $"Total passengers: {totalPassengers}\n" +
                $"Total cost: {totalCost}");
        }
    }
}
