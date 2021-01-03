using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Reusing_classes
{
    public class Earh : IPlanet
    {
        public void ReportAboutLife()
        {
            Console.WriteLine("I`m alive. Yeah...");
        }

        public void ReportAboutMovement()
        {
            Console.WriteLine("Moving near Moon");
        }
    }
}
