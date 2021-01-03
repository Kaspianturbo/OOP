using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Reusing_classes
{
    public class Moon : IPlanet
    {
        public void ReportAboutLife()
        {
            Console.WriteLine("Americans were here...");
        }

        public void ReportAboutMovement()
        {
            Console.WriteLine("Moving near Earh");
        }
    }
}
