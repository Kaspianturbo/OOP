using System;

namespace Lab4_Overiding_opers
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector.IntervalA = 0;
            Vector.IntervalB = 5;
            var vector1 = new Vector(new int[] { 0, 4, 12, 44, 241, 1, 11, 6 });
            var vector2 = new Vector(new int[] { 2, -3, 1, 74, 11, 1, 91, 6 });
            var inRange = vector1 | vector2;
            Console.WriteLine($"From {Vector.IntervalA} to {Vector.IntervalB}: {inRange} elems");
        }
    }
}
