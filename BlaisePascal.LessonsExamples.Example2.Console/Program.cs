using BlaisePascal.LessonsExamples.Example2.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonsExamples.Example2.UIConsole
{
    internal class Program
    {
        public static void Main()
        {
            Vehicle vehicle = new Vehicle("AB 123VF");
            string licensePlate = vehicle.LicensePlate;

            Console.WriteLine(licensePlate); //Console.WriteLine() tries to call the ToString method for each argument
        }
    }
}