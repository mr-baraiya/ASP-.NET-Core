using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_A_Solution
{
    internal class Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Speed { get; set; }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }

    }
    class Car : Vehicle
    {
        public string FuelType { get; set; }
        public Car(string model, string brand, int speed, string fuelType)
        {
            Model = model;
            Brand = brand;
            Speed = speed;
            FuelType = fuelType;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Car Details:");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Fuel Type: {FuelType}");
        }
    }
    class Bike : Vehicle
    {
        public string WheelType { get; set; }
        public Bike(string model, string brand, int speed, string wheelType)
        {
            Model = model;
            Brand = brand;
            Speed = speed;
            WheelType = wheelType;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Bike Details:");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Wheel Type: {WheelType}");
        }
    }
}
