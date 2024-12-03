using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Write a program to create a class Staff having data members as Name,
//Department, Designation, Experience & Salary. Accept this data for 5
//different staffs and display only names & salary of those staff who are 
//HOD.

namespace ConsoleApp2
{
    internal class Staff
    {
        public String name;
        public String department;
        public String designation;
        public int experience;
        public double salary;

        public void getStaffDetails()
        {
            Console.WriteLine("Enter The Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Department : ");
            department = Console.ReadLine();
            Console.WriteLine("Enter the Designation : ");
            designation = Console.ReadLine();
            Console.WriteLine("Enter the Experience : ");
            experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
    }
}
