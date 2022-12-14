using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCar { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is now in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This car is virtually driving!");
        }
    }
}
