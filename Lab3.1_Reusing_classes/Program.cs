using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab3._1_Reusing_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRepeat, isValid;
            Flights flights = new Flights();
            flights.Items = new List<Flight>();
            Regex uInteger = new Regex("^[0-9]*$");
            Regex uDouble = new Regex("^[0-9]*[.,]?[0-9]+$");
            do
            {
                do
                {
                    Console.Write("Enter:\ntype: ");
                    var inputType = Console.ReadLine();
                    Console.Write("Number of flight: ");
                    var inputNumber = Console.ReadLine();
                    Console.Write("Passengers count: ");
                    var inputCount = Console.ReadLine();
                    Console.Write("Cost per flight: ");
                    var inputCost = Console.ReadLine();

                    isValid = uInteger.IsMatch(inputNumber) && uInteger.IsMatch(inputCount) && uDouble.IsMatch(inputCost);

                    if (isValid)
                    {
                        var number = Convert.ToInt32(inputNumber);
                        var count = Convert.ToInt32(inputCount);
                        var cost = Convert.ToDouble(inputCost);
                        flights.Items.Add(new Flight(inputType, number, count, cost));
                    }
                    else Console.WriteLine("Bad try. Enter valid data.");
                } while (!isValid);

                Console.WriteLine("\nEnter again? Y/N");
                var inputRepeat = Console.ReadLine();

                if (inputRepeat == "Y") isRepeat = true;
                else isRepeat = false;

                Console.Clear();
            } while (isRepeat);

            flights.ToConsole();
            flights.TotalToConsole();
        }
    }
}
