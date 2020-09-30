using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4_Overiding_opers
{
    class Vector
    {
        //private int[] arr;
        public int[] arr { get; private set; }
        public int Length => arr.Length;
        public static int IntervalA { get; set; } = 0;
        public static int IntervalB { get; set; } = 0;
        public Vector(int[] arr)
        {
            this.arr = arr;
        }
        public static int operator |(Vector v1, Vector v2)
        {
            int res = 0;
            foreach (int elem in v1.arr)
            {
                if (elem >= IntervalA && elem <= IntervalB) res++;
            }
            foreach (int elem in v2.arr)
            {
                if (elem >= IntervalA && elem <= IntervalB) res++;
            }
            return res;
        }
        public void Add(int elem)
        {
            var list = arr.ToList();
            list.Add(elem);
            arr = list.ToArray();
        }
        public void ToConsole()
        {
            foreach (int elem in arr)
                Console.Write(elem + " ");
        }
        //public int[] GetArray() => arr;
    }
}
