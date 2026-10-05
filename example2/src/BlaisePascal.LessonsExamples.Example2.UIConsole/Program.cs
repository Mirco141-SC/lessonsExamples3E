using BlaisePascal.LessonsExamples.Example2.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonsExamples.Example2.UIConsole
{
    internal class Program
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle("AB 123VF");
            string licensePlate = vehicle.LicensePlate;

            Console.WriteLine(licensePlate); //Console.WriteLine() tries to call the ToString method for each argument

            Vehicle vehicle1 = new Vehicle("xyz", -1, 50, 75);
            Console.WriteLine(vehicle1.LicensePlate);
            Console.WriteLine(vehicle1.OdometerKm);
            Console.WriteLine(vehicle1.DailyRate);
            Console.WriteLine(vehicle1.FuelLevelPercentage);
        }
    }
}