using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_A_Solution
{
    internal class Employee
    {
        String Name;
        int id;
        String Position;
        Double Salary;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter the Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Position of Employee : ");
            Position = Console.ReadLine();
            Console.WriteLine("Enter the Salary Of Employee : ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID = {id}");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Position = {Position}");
            Console.WriteLine($"Salary = {Salary}");
        }
    }
    abstract class Employee2
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        // Abstract methods to be implemented by derived classes
        public abstract void CalculateSalary(int hoursWorked, double hourlyRate);
        public abstract void DisplayEmployeeDetails();
    }
    class FullTimeEmployee : Employee2
    {
        public double Salary { get; private set; }
        // Implementation of CalculateSalary
        public override void CalculateSalary(int hoursWorked, double hourlyRate)
        {
            Salary = hoursWorked * hourlyRate;
        }
        // Implementation of DisplayEmployeeDetails
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
