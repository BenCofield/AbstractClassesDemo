using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleUI;
using Microsoft.VisualBasic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var c1 = new Car()
            {
                HasTrunk = true,
                Year = 2014,
                Make = "Honda",
                Model = "Civic EX"
            };
            var m1 = new Motorcycle()
            {
                HasSideCart = true,
                Year = 2000,
                Make = "Honda",
                Model = "Trail125",
            };

            Vehicle vehicle1 = new Car()
            {
                HasTrunk = false,
                Year = 1998,
                Make = "Porsche",
                Model = "911",
            };

            Vehicle vehicle2 = new Motorcycle()
            {
                HasSideCart = false,
                Year = 2014,
                Make = "Mitsubishi",
                Model = "Eclipse GT",
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(c1);
            vehicles.Add(m1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}\n" +
                                  $"Make: {vehicle.Make}\n" +
                                  $"Model: {vehicle.Model}\n");

                
            }
            // Call each of the drive methods for one car and one motorcycle
            m1.DriveVehicle(m1);
            c1.DriveVehicle(c1);
            #endregion
            Console.ReadLine();
        }
    }
}
