using System;

namespace Lab1_Basiсs_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine($"Shevchenko Victor \tTime: {DateTime.Now}");
            Console.Write("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"ln(a) = {Math.Log(a)}");
            Console.ReadKey();
        }
    }
}
