using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 7. Write a program to Define a class Salary which will contain member 
variable Basic, TA, DA, HRA. Write a program using Constructor with default 
values for DA and HRA and calculate the salary of employee. */
namespace ConsoleApp2
{
    internal class Salary
    {
        public int basic;
        public int ta;
        public int da;
        public int hra;
        public Salary(int basic,int ta)
        {
            this.basic = basic;
            this.ta = ta;
            da = 2000;
            hra = 10000;
        }
        public double calSalary()
        {
            return Convert.ToDouble(basic + ta + da + hra);
        }
    }
}
