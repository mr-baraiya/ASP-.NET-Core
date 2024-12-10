using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

//7.Write a program to create interface named Shape.In this interface, we
//have three methods Circle(), Triangle() and Square() which calculates area
//of Circle, Triangle and Square respectively.Implement Shape interface.
namespace ConsoleApp3
{
    internal interface Shape
    {
        double Circle(double r);
        double Triangle(double h, double b);
        double Square(double l);
    }

    internal class Area : Shape
    {
        public double Circle(double r)
        {
            return ( Math.PI * r * r );
        }
        public double Triangle(double h , double b)
        {
            return ( 0.5 * h * b );
        }
        public double Square(double l)
        {
            return ( l * l );
        }
    }
}
