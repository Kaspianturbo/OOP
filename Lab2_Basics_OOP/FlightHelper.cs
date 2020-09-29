using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Basics_OOP
{
    public static class FlightHelper
    {
        public static Flight[] GetMocksFlights(int count)
        {
            var flights = new List<Flight>();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                var passagers = random.Next() % 320;
                var cost = random.Next() % 100 * 100;
                flights.Add(new Flight("Some type", i, passagers, cost));
            }       
            return flights.ToArray();
        }
        public static void ToConsole(Flight flight)
        {
            Console.WriteLine($"" +
                $"Type: {flight.GetT()}\n" +
                $"Number of flight: {flight.GetR()}\n" +
                $"Passengers count: {flight.GetK()}\n" +
                $"Cost per flight: {flight.GetZ()}\n" +
                $"Cost pey person: {flight.GetS()}\n");
        }
        public static void ToConsole(IEnumerable<Flight> flights)
        {
            foreach (Flight flight in flights)
            {
                ToConsole(flight);
            }
        }
        public static void TotalToConsole(IEnumerable<Flight> flights)
        {
            var totalCost = 0d;
            var totalPassengers = 0;
            var totalFlights = 0;
            foreach (Flight flight in flights)
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
