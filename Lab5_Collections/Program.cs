﻿using System;
using System.Collections.Generic;

namespace Lab5_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Flight> flights;
            Console.WriteLine("Create flight: 1 \nRead flights: 2");
            var ansrer = Console.ReadLine();
            if (ansrer == "1")
            {
                flights = new Stack<Flight>();
                var isEndCreating = false;
                do
                {
                    Console.Write("Enter:\ntype: ");
                    var type = Console.ReadLine();
                    Console.Write("Number of flight: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Passengers count: ");
                    var count = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Cost per flight: ");
                    var cost = Convert.ToDouble(Console.ReadLine());

                    flights.Push(new Flight(type, number, count, cost));

                    Console.WriteLine("\nEnter again? Y/N");
                    if (Console.ReadLine() == "N")
                    {
                        isEndCreating = true;
                        Console.WriteLine("Where you want to save info?");
                        var path = Console.ReadLine();
                        FlightHelper.AppendToFile(flights, path);
                    }
                    Console.Clear();
                } while (!isEndCreating);
            }
            else
            {

                Console.Clear();
                Console.WriteLine("Read from: ");
                var path = Console.ReadLine();
                var array = FlightHelper.ReadFromFile(path);
                flights = new Stack<Flight>(array);
                FlightHelper.ToConsole(flights);
                FlightHelper.TotalToConsole(flights);
            }
        }
    }
}
