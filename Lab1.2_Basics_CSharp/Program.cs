using System;
using System.Text.RegularExpressions;

namespace Lab1._2_Basics_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFrom, inputTo;
            double from, to;
            bool isValid;
            Regex regex = new Regex("^[-]?([0-9]+[.,])?[0-9]+$");
            do 
            {
                Console.WriteLine("Enter range");
                Console.Write("From: ");
                inputFrom = Console.ReadLine();
                Console.Write("To: ");
                inputTo = Console.ReadLine();

                isValid = regex.IsMatch(inputFrom) && regex.IsMatch(inputTo);

                if (isValid)
                {
                    from = Convert.ToDouble(inputFrom);
                    to = Convert.ToDouble(inputTo);
                    Console.WriteLine($"°F\t°C");
                    for (double i = from; i <= to; i++)
                    {
                        var f = Math.Round(i, 2);
                        var celsius = Math.Round(TemperatureConvertor.ToСelsius(f), 2);
                        Console.WriteLine($"{f}\t{celsius}");
                    }
                }
                else Console.WriteLine("Bad try. Enter valid data.");
            } while (!isValid);
        }
    }
}
