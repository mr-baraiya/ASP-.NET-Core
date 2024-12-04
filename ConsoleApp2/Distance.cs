using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8.Write a program to Define a class Distance have data members dist1, dist2,
//dist3. Initialize the two data members using constructor and store their 
//addition in third data member using function and display addition.

namespace ConsoleApp2
{
    internal class Distance
    {
        int dist1;
        int dist2;
        int dist3;
        public Distance(int dist1,int dist2) 
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }
        public void addTwoDistance()
        {
            dist3 = dist1 + dist2;
        }
        public void displayAddition()
        {
            Console.WriteLine("Addition : "+dist3);
        }
    }
}
