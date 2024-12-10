using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5. Write a program to calculate area of a Rectangle using constructor.

namespace ConsoleApp2
{
    internal class Rectangle
    {
        public double length;
        public double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double calculateAreaOfRectangle()
        {
            return length * width;
        }
    }
}
