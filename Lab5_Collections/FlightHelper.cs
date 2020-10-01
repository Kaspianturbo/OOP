using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Lab5_Collections
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
                $"Type: {flight.T}\n" +
                $"Number of flight: {flight.R}\n" +
                $"Passengers count: {flight.K}\n" +
                $"Cost per flight: {flight.Z}\n" +
                $"Cost pey person: {flight.S}\n");
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
                totalCost += flight.Z;
                totalPassengers += flight.K;
                totalFlights++;
            }

            Console.WriteLine($"Total flights: {totalFlights}\n" +
                $"Total passengers: {totalPassengers}\n" +
                $"Total cost: {totalCost}");
        }
        public static void AppendToFile(Flight flight, string fileName)
        {
            var content = "";
            content += $"{flight.T}#" +
                $"{flight.R}#" +
                $"{flight.K}#" +
                $"{flight.Z}\n";

            File.AppendAllText(fileName, content);
        }
        public static void AppendToFile(IEnumerable<Flight> flights, string fileName)
        {
            foreach (Flight flight in flights)
            {
                AppendToFile(flight, fileName);
            }
        }
        public static IEnumerable<Flight> ReadFromFile(string source)
        {
            var content = File.ReadAllText(source);
            List<Flight> flights = new List<Flight>();
            var lines = content.Split("\n");
            //Remove last item ""
            var list = lines.ToList();
            list.RemoveAt(list.Count - 1);
            lines = list.ToArray();

            foreach (string line in lines)
            {
                var values = line.Split("#");
                var type = values[0];
                var num = Convert.ToInt32(values[1]);
                var count = Convert.ToInt32(values[2]);
                var cost = Convert.ToDouble(values[3]);
                yield return new Flight(type, num, count, cost);
            }
        }
    }
}
