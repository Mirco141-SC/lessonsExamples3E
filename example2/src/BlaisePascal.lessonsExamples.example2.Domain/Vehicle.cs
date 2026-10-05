using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonsExamples.Example2.Domain
{
    public class Vehicle
    {
        //private string _licensePlate;
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        //Properties in C# are 'disguised' methods, so their naming starts with a capital letter
        //Since it has the same name of an attribute (_licensePlate) it is connected to it, meaning value will be updated by the .NET in both the attribute and property
        //Though if we declare a property we should NOT use the attribute anymore, so we can also delete it
        //The compiler will still create a hidden "backfield" as an attribute. The value actually stays there, the property is just an interface to interact with it
        //
        //Getter and setter, if not declared, do NOT exist default
        public string LicensePlate { get; private set; }
        public int OdometerKm
        {
            get
            { return _odometerKm; }
            private set
            {
                if (value < 0) throw new ArgumentException($"Value not allowed in {nameof(OdometerKm)}: {value}");

                _odometerKm = value;
            }
        }
        public double DailyRate { get; private set; }
        public double FuelLevelPercentage { get; private set; }

        //The constructor is the ONE AND ONLY method that does NOT require return type definition
        //It has the same name as the class, and is called when creating a new object
        //
        //If we don't declare a constructor, the compiler will run a default one (empty)
        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        //The constructor can be overloaded as any other method
        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLevelPercentage)
        {
            LicensePlate = licensePlate;
            OdometerKm = odometerKm;
            DailyRate = dailyRate;
            FuelLevelPercentage = fuelLevelPercentage;
        }
    }
}