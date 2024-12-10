using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

//1.Write a program to create a class named Candidate with ID, Name, Age,
//Weight and Height as data members & also create a member functions like
//GetCandidateDetails() and DisplayCandidateDetails(). 

namespace ConsoleApp2
{
    internal class Candidate
    {
        public int id;
        public string name;
        public int age;
        public double weight;
        public double height;

        public void getCandidateDetails()
        {
            Console.WriteLine("Enter the Id of candidate : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of candidate : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Age of candidate : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Weight of candidate : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Height of candidate : ");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public void displayCandidateDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("Weight : " + weight);
        }
    }
}
