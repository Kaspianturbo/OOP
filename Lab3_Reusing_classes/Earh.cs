using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Reusing_classes
{
    public class Earh : Planet
    {
        public override void ReportAboutLife()
        {
            Console.WriteLine("I`m alive. Yeah...");
        }

        public override void ReportAboutMovement()
        {
            Console.WriteLine("Moving near Moon");
        }
    }
}
