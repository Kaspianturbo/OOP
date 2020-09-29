using System;
using System.Collections.Generic;

namespace Lab3_Reusing_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var earh = new Earh();
            var moon = new Moon();

            List<Planet> spaceObjects = new List<Planet>();

            spaceObjects.Add(earh);
            spaceObjects.Add(moon);

            foreach (Planet planet in spaceObjects)
            {
                Console.WriteLine(planet.ToString());
                planet.ReportAboutLife();
                planet.ReportAboutMovement();
                Console.WriteLine();
            }
        }
    }
}
