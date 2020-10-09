using System;


namespace Lab6_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            bool isValid = Analizator.IsValid(str);
            Console.WriteLine(isValid);
            Console.ReadKey();
        }
    }
}
