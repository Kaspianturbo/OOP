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

            List<IPlanet> spaceObjects = new List<IPlanet>();

            spaceObjects.Add(earh);
            spaceObjects.Add(moon);

            foreach (IPlanet planet in spaceObjects)
            {
                Console.WriteLine(planet.ToString());
                planet.ReportAboutLife();
                planet.ReportAboutMovement();
                Console.WriteLine();
            }
        }
    }
}
