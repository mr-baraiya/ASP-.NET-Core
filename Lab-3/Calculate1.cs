using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface Calculate1
    {
        int addition(int a, int b);
        int substraction(int a, int b);
    }

    internal class Result : Calculate1
    {
        public int addition(int a,int b)
        {
            return a + b;
        }
        public int substraction(int a, int b)
        {
            return a - b;
        }
    }
}
