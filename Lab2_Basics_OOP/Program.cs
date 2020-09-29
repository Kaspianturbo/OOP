using System;

namespace Lab2_Basics_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var flight1 = new Flight("Boing", 65141, 256, 2680000);
            flight1.AccountS();
            FlightHelper.ToConsole(flight1);

            Flight[] flights = FlightHelper.GetMocksFlights(3);
            FlightHelper.ToConsole(flights);
            FlightHelper.TotalToConsole(flights);
        }
    }
}
