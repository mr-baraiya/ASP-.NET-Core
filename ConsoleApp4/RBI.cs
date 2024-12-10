using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Create a class named RBI with calculateInterest() method.Create another
//classes HDFC, SBI, ICICI which overrides calculateInterest() method.

namespace ConsoleApp4
{
    internal class RBI
    {
        public virtual void calculateInterest(double p, double r, double t)
        {
            Console.WriteLine($"I = {(p * r * t) / 100}");
        }
    }
    internal class HDFC : RBI
    {
        public override void calculateInterest(double p, double r, double t)
        {
            base.calculateInterest(p, r, t);
            Console.WriteLine("HDFC Bank");
        }
    }
    internal class SBI : RBI
    {
        public override void calculateInterest(double p, double r, double t)
        {
            base.calculateInterest(p, r, t);
            Console.WriteLine("SBI Bank");
        }
    }
    internal class ICICI : RBI
    {
        public override void calculateInterest(double p, double r, double t)
        {
            base.calculateInterest(p, r, t);
            Console.WriteLine("ICICI Bank");
        }
    }
}
