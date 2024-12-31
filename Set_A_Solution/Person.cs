using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_A_Solution
{
    //Write a program to create a base class Person with attributes Name and Age, then derive two classes
    //Employee and Manager, where Employee adds EmployeeID and Salary, and Manager adds
    //Department, overriding the DisplayDetails() method to show all details.
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
    class Employee1 : Person
    {
        public int EmployeeID { get; set; }
        public double Salary { get; set; }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
    class Manager : Employee1
    {
        public string Department { get; set; }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Department: {Department}");
        }
    }

}
