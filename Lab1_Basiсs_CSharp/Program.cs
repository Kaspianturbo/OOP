using System;
using System.Text.RegularExpressions;

namespace Lab1_Basiсs_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("^([0-9]+[.,])?[0-9]+$");
            double a;
            bool isValid;
            Console.WriteLine($"Shevchenko Victor \tTime: {DateTime.Now}");
            do {           
                Console.Write("Enter a: ");
                string input = Console.ReadLine();
                isValid = regex.IsMatch(input);
                if (isValid == true)
                {
                    a = Convert.ToDouble(input);
                    Console.WriteLine($"ln(a) = {Math.Log(a)}");
                    Console.ReadKey();
                }
                else Console.WriteLine("Bad try. Enter valid data.");
            } while (!isValid);
        }
    }
}
