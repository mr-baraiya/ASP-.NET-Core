using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.Create a class Furniture with material, price as data members. Create 
//another class Table with Height, surface_area as data members. Write a
//program to implement single inheritance.

namespace ConsoleApp2
{
    internal class Furniture
    {
        public String material;
        public Double price;
        public Furniture (String material,Double price)
        {
            this.material = material;
            this.price = price;
        }
    }
    internal class Table : Furniture
    {
        public double height;
        public double surface_area;

        public Table (double height, double surface_area, String material, double price) : base(material, price)
        {
            this.height = height;
            this.surface_area = surface_area;
        }
    }
}
