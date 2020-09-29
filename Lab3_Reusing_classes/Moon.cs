using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Reusing_classes
{
    public class Moon : Planet
    {
        public override void ReportAboutLife()
        {
            Console.WriteLine("Americans were here...");
        }

        public override void ReportAboutMovement()
        {
            Console.WriteLine("Moving near Earh");
        }
    }
}
