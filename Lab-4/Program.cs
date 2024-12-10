using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program using method overloading by changing datatype of
            //arguments to perform addition of two integer numbers and two float
            //numbers.
            //Console.WriteLine($"35 + 56 = {add(35,36)}");
            //Console.WriteLine($"23.45 + 45.67 = {add(23.45f,45.67f)}");

            //2.Write a program using method overloading by changing number of
            //arguments to calculate area of square and rectangle.
            //Console.WriteLine($"(L = 35) Area Of Square = {areaOfSquareAndRactangle(35)}");
            //Console.WriteLine($"(L = 23 , B = 45) Area Of Ractangle = {areaOfSquareAndRactangle(23,45)}");

            //3.Create a class named RBI with calculateInterest() method.Create another
            //classes HDFC, SBI, ICICI which overrides calculateInterest() method
            //HDFC a1 = new HDFC();
            //SBI a2 = new SBI();
            //ICICI a3 = new ICICI();
            //a1.calculateInterest(10000, 5, 5);
            //a2.calculateInterest(10000, 5, 5);
            //a3.calculateInterest(10000, 5, 5);

            //4. Create a class Hospital with HospitalDetails() method. Create another 
            //classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
            //HospitalDetails() method.
            //Apollo apollo = new Apollo();
            //apollo.HospitalDetails("Apollo");
            //Wockhardt wockhardt = new Wockhardt();
            //wockhardt.HospitalDetails("Wockhardt");
            //Gokul_Superspeciality gokul_Superspeciality = new Gokul_Superspeciality();
            //gokul_Superspeciality.HospitalDetails("Gokul Superspeciality");

            //5. Write a programs to Find Area of Square, Rectangle and Circle using 
            //Method Overloading.
            //Console.WriteLine("Area of Circle with (r = 12.34) : " + areaOfSRC(12.34));
            //Console.WriteLine("Area of Square with (l = 12) : " + areaOfSRC(12));
            //Console.WriteLine("Area of Rectangle with (l = 12 , b = 8) : " + areaOfSRC(12,8));

            //6.Create a BankAccount class having constructor accepting initialBalance and
            //accountHolderName.Also create Deposite() and withdraw() overloaded
            //methods by which user can deposit/withdraw amount using different types
            //of parameters(ex.cash, check).
            //Console.WriteLine("Enter the Account Holder Name : ");
            //String name = Console.ReadLine();
            //Console.WriteLine("Enter the Account Balance : ");
            //Double Balance = Convert.ToDouble(Console.ReadLine());
            //BankAccount b = new BankAccount(Balance, name);
            //b.deposit(1000);
            //b.withdraw(500);
            //b.deposit(100.50);
            //b.withdraw(450.25);
            //Console.WriteLine("Your Balance : "+b.getBalance());

        }
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static float add(float x, float y)
        {
            return x + y;
        }
        public static int areaOfSquareAndRactangle(int l)
        {
            return l * l;
        }
        public static int areaOfSquareAndRactangle(int l,int b)
        {
            return l * b;
        }

        public static double areaOfSRC(double r)
        {
            return (Math.PI * r * r);
        }

        public static int areaOfSRC(int l)
        {
            return (l * l);
        }

        public static int areaOfSRC(int l , int b)
        {
            return (l * b);
        }
    }
}
