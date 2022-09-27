using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2000;
        public string Make { get; set; } = "Unknown";
        public string Model { get; set; } = "Unknown";

        public abstract void DriveAbstract(Vehicle vehicle);

        public virtual void DriveVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Accelerate");
        }
    }

    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = false;

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine("Start the car, put in gear");
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine("Key in, start engine, put in first gear");
        }

        public override void DriveVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Accelerate");
            Console.WriteLine("Shift up");
        }
    }
}
