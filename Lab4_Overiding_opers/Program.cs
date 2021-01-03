using System;
using System.Text.RegularExpressions;

namespace Lab4_Overiding_opers
{
    class Program
    {
        static void Main(string[] args)
        {
            var integer = new Regex("^[-]?[0-9]*$");
            var uInteger = new Regex("^[0-9]*$");
            bool isInteger, isValid;
            int length = 0;
            Vector vector1, vector2;
            do
            {
                Console.Write("Enter A: ");
                var inputA = Console.ReadLine();
                Console.Write("Enter B: ");
                var inputB = Console.ReadLine();
                Console.Write("Enter array length: ");
                var inputLength = Console.ReadLine();
                isInteger = integer.IsMatch(inputA) && integer.IsMatch(inputB) && uInteger.IsMatch(inputLength);
                if (isInteger == true)
                {
                    var a = Convert.ToInt32(inputA);
                    var b = Convert.ToInt32(inputB);
                    Vector.IntervalA = a;
                    Vector.IntervalB = b;
                    length = Convert.ToInt32(inputLength);
                }
                else Console.WriteLine("Bad try. Enter valid data.");
            } while (!isInteger);

            vector1 = new Vector();
            Console.WriteLine("Fill first array.");
            for (int i = 0; i < length; i++)
            {
                Console.Write(i + 1 + " = ");
                var inputElem = Console.ReadLine();
                if (integer.IsMatch(inputElem))
                {
                    var elem = Convert.ToInt32(inputElem);
                    vector1.Add(elem);
                }
                else
                {
                    i--;
                    Console.WriteLine("Enter valid data");
                }
            }

            vector2 = new Vector();
            Console.WriteLine("Fill second array.");
            for (int i = 0; i < length; i++)
            {
                Console.Write(i + 1 + " = ");
                var inputElem = Console.ReadLine();
                if (integer.IsMatch(inputElem))
                {
                    var elem = Convert.ToInt32(inputElem);
                    vector2.Add(elem);
                }
                else
                {
                    i--;
                    Console.WriteLine("Enter valid data");
                }
            }
            vector1.ToConsole();
            vector2.ToConsole();
            var inRange = vector1 | vector2;
            Console.WriteLine($"From {Vector.IntervalA} to {Vector.IntervalB}: {inRange} elems");
        }
    }
}
