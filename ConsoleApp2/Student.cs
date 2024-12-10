using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    4. Write a program with following specifications: 
    Class Name: Student
    Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
    Get Students Details using constructor and DisplayStudentDetails() using 
    member function
 */

namespace ConsoleApp2
{
    internal class Student
    {
        public double enrollmentNo;
        public String studentName;
        public int semester;
        public double cpi;
        public double spi;

        public Student()
        {
            Console.WriteLine("EnrollmentNo : ");
            enrollmentNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("StudentName : ");
            studentName = Console.ReadLine();
            Console.WriteLine("Semester : ");
            semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SPI : ");
            spi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("CPI : ");
            cpi = Convert.ToDouble(Console.ReadLine());
        }

        public void displayStudentDetails()
        {
            Console.WriteLine("EnrollmentNo : " + enrollmentNo);
            Console.WriteLine("StudentName : " + studentName);
            Console.WriteLine("Semester : " + semester);
            Console.WriteLine("SPI : " + spi);
            Console.WriteLine("CPI : " + cpi);
        }
    }
}
