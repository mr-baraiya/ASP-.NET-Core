using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Set_A_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program-1
            //Write a program to convert a given value based on user choice: kilometers to miles, pounds to
            //kilograms, or liters to gallons, using switch case the formulas provided.
            //Miles = Kilometers * 0.621371
            //Kilograms = Pounds * 0.453592
            //Gallons = Liters * 0.264172
            //    int n = 0;
            //    do
            //    {
            //        Console.WriteLine("\n Enter -1 for Exit. \n Enter 1 for Kilometers -> Miles. \n Enter 2 for Pounds -> Kilograms. \n Enter 3 for Liters -> Gallons. \n");
            //        n = Convert.ToInt32(Console.ReadLine());
            //        switch (n)
            //        {
            //            case 1:
            //                Console.WriteLine("Enter Kilometers : ");
            //                double d = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"{d} Kilometers = {d * 0.621371} Miles");
            //                break;
            //            case 2:
            //                Console.WriteLine("Enter Pounds : ");
            //                double w = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"{w} Pounds = {w * 0.453592} Kilogrames");
            //                break;
            //            case 3:
            //                Console.WriteLine("Enter Liters : ");
            //                double v = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"{v} Liters = {v * 0.264172} Gallons");
            //                break;
            //            case -1:
            //                Console.WriteLine("Program Was Successfully Complated!");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid Inputs!");
            //                break;
            //        }
            //    } while (n != -1);

            //Program-2
            //Write a program that accepts two strings from the user and uses string methods to compare them
            //(using Equals()), concatenate them(Concat()), and convert one string to uppercase(ToUpper()).
            //Handle any exceptions if an invalid input is provided.
            //try
            //{
            //    Console.WriteLine("Enter the String1 : ");
            //    String s1 = Console.ReadLine();
            //    Console.WriteLine("Enter the String2 : ");
            //    String s2 = Console.ReadLine();
            //    string s = string.Concat(s1, s2);
            //    Console.WriteLine($"s1.Equals(s2) = {s1.Equals(s2)}");
            //    Console.WriteLine($"s1.Concat(s2) = {s}");
            //    Console.WriteLine($"s1.ToUpper()  = {s1.ToUpper()}");
            //}
            //catch (Exception e) 
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Program-3
            //Write a program using method overloading to create a class Calculator with methods Multiply(int a,
            //int b), Multiply(double a, double b), and Multiply(float a, float b) to perform multiplication of two
            //integers, two doubles, and two floats respectively.
            //Calculater c = new Calculater();
            //Console.WriteLine($"12 * 13 = {c.Multiply(12,13)}");
            //Console.WriteLine($"12.23 * 32.45 = {c.Multiply(12.23f,32.45f)}");
            //Console.WriteLine($"12.345678 * 2.341234 = {c.Multiply(12.345678,2.341234)}");

            //Program-4
            //Write a program to create a class Employee with data members Name, ID, Position, and Salary.
            //Create a function GetEmployeeDetails() to accept data and a DisplayEmployeeDetails() function to
            //display the details of the employee.
            //Employee employee = new Employee();
            //employee.GetEmployeeDetails();
            //employee.DisplayEmployeeDetails();

            //Position-5
            //Write a program to create a base class Person with attributes Name and Age, then derive two classes
            //Employee and Manager, where Employee adds EmployeeID and Salary, and Manager adds
            //Department, overriding the DisplayDetails() method to show all details.
            //Employee1 e = new Employee1
            //{
            //    Name = "Alice",
            //    Age = 30,
            //    EmployeeID = 12345,
            //    Salary = 50000
            //};
            //// Create a Manager object
            //Manager m = new Manager
            //{
            //    Name = "Bob",
            //    Age = 40,
            //    EmployeeID = 67890,
            //    Salary = 75000,
            //    Department = "IT"
            //};
            //// Display details of Employee
            //Console.WriteLine("Employee Details:");
            //e.DisplayDetails();
            //Console.WriteLine("\nManager Details:");
            //// Display details of Manager
            //m.DisplayDetails();

            //Program-6
            //Design a program with a Vehicle class having attributes Model, Brand, and Speed, and derive Car and
            //Bike classes with additional attributes FuelType and WheelType, implementing constructors and
            //overriding DisplayDetails to display respective details
            // Create a Car object
            //Car car = new Car("Model S", "Tesla", 200, "Electric");
            //// Create a Bike object
            //Bike bike = new Bike("Ninja ZX-10R", "Kawasaki", 300, "Sport");
            //// Display details of Car
            //car.DisplayDetails();
            //Console.WriteLine();
            //// Display details of Bike
            //bike.DisplayDetails();

            //Program-7
            //Write a program to create an abstract class Employee with abstract methods CalculateSalary() and
            //DisplayEmployeeDetails(). Create a derived class FullTimeEmployee that implements these methods
            //and calculates the salary based on hours worked and hourly rate.Demonstrate the functionality by
            //creating an instance of FullTimeEmployee and displaying the details.
            // Create an instance of FullTimeEmployee
            //FullTimeEmployee employee = new FullTimeEmployee
            //{
            //    EmployeeID = 101,
            //    Name = "John Doe"
            //};
            //// Calculate salary
            //int hoursWorked = 160; // Example: 160 hours in a month
            //double hourlyRate = 50; // Example: $50 per hour
            //employee.CalculateSalary(hoursWorked, hourlyRate);
            //// Display employee details
            //employee.DisplayEmployeeDetails();
        }
    }
}
