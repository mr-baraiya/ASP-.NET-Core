using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp2;

//10.Program to implement the following multiple inheritance using interface
//Interface : Gross
//Method- Gross_sal()
//Class : Salary
//Data Members - HRA, TA, DA
//Methods - Disp_sal()
//Class : Employee
//Data Members - Name
//Methods - basic_sal()

namespace ConsoleApp2
{
    internal interface Gross
    {
        void gross_sal();
    }
    internal class Salary1 : Gross
    {
        public int hra;
        public int da;
        public int ta;
        public int basic;
        public void disp_sal()
        {
            Console.WriteLine("Salary : " + (hra + ta + da));
        }
        public void gross_sal() 
        {
            hra += 5000;
            da += 1000;
            ta += 2000;
        }
    }
    internal class Employee : Salary1
    {
        String name;
        public void basic_sal()
        {
            Console.WriteLine("Basic Salary : "+ basic);
        }
    }
}
