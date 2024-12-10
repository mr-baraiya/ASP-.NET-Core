using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program to print your name, address, contact number & city.

            //Console.WriteLine("My Name is Vishal Baraiya");
            //Console.WriteLine("My Contact Number is 1234567890");
            //Console.WriteLine("My Adress is : Kalawad Road , Rajkot");
            //Console.WriteLine("I am from Rajkot.");


            //2. Write a program to get two numbers from user and print those twos numbers.

            //Console.WriteLine("Enter the first Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("a = "+a);
            //Console.WriteLine("b = "+b);

            //3. Write program to prompt a user to input his/her name and country name
            //and then output will be shown as given: Hello <yourname> from country
            //<countryname>

            //Console.WriteLine("Enter your Name : ");
            //String userName = Console.ReadLine();
            //Console.WriteLine("Enter your Country Name : ");
            //String countryName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName + " from country " + countryName + ".");

            //4. Write a program to calculate the size of the area in square-feet based on
            //Specified length and width.

            //Console.WriteLine("Enter the length :");
            //int l = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the width :");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Area = " + (l * b));

            //5. Write a program to calculate area of Square, Rectangle and Circle.

            //For Square
            //Console.WriteLine("Enter the length of Sqaure:");
            //int l = Convert.ToInt32(Console.ReadLine());
            //int area = l * l;
            //Console.WriteLine("The Area = " + area);

            //For Rectangle
            //Console.WriteLine("Enter the length :");
            //int l = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the breath :");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int area = l * b;
            //Console.WriteLine("The Area = " + area);

            //For Circle
            //Console.WriteLine("Enter the radius of Cicle :");
            //int r = Convert.ToInt32(Console.ReadLine());
            //double area = Math.PI * r * r;
            //Console.WriteLine("The Area = " + area);

            //6. Write a program to calculate Celsius to Fahrenheit and vice-versa using function.

            //Console.WriteLine("Enter the temprature in Celcius : ");
            //double c = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Temprature in farehenhit : " + convertToFarenheit(c));

            //Console.WriteLine("Enter the temprature in Farehenhit : ");
            //double f = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Temprature in Celcius : " + convertToCelsius(f));

            //7. Write a program to find out Simple Interest using function. (I = PRN/100)

            //Console.WriteLine("Enetr the P : ");
            //double p = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enetr the R : ");
            //double r = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enetr the N : ");
            //double n = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Interest is = " + calculateInrest(p,r,n));

            //8. Write a program to create a Simple Calculator for two numbers (Addition,
            //Multiplication, Subtraction, Division) [Also using if…else & Switch Case]

            //bool flag = true;
            //do
            //{
            //    Console.WriteLine("Enter + , - , * , / , % , exit .");
            //    String str = Console.ReadLine();
            //    double n1 = 0, n2 = 0;
            //    if(str != "exit")
            //    {
            //        Console.WriteLine("Enter the firtst Number : ");
            //        n1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Enter the Second Number : ");
            //        n2 = Convert.ToInt32(Console.ReadLine());
            //    }
            //    switch (str)
            //    {
            //        case "+" :
            //            Console.WriteLine("Addition : " + (n1 + n2));
            //            break;
            //        case "-":
            //            Console.WriteLine("Subtraction : " + (n1 - n2));
            //            break;
            //        case "*":
            //            Console.WriteLine("Multiplaction : " + (n1 * n2));
            //            break;
            //        case "/":
            //            Console.WriteLine("Division : " + (double)(n1 / n2));
            //            break;
            //        case "%":
            //            Console.WriteLine("Modulo : " + (n1 % n2));
            //            break;
            //        case "exit":
            //            flag = false;
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Input!");
            //            break;
            //    }
            //} while (flag);
            //Console.WriteLine("Program will Complated");

            //9. Write a program to Swapping without using third variable.
            //Console.WriteLine("Enter the firtst Number : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number : ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //n1 = n1 + n2;
            //n2 = n1 - n2;
            //n1 = n1 - n2;
            //Console.WriteLine("n1 = " + n1);
            //Console.WriteLine("n2 = " + n2);


            //10.Write a program to find maximum numbers from given 3 numbers using
            //ternary operator.

            //Console.WriteLine("Enter the firtst Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the third Number : ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //int max = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
            //Console.WriteLine("Max = " + max);

            //while (true)
            //{
            //    ConsoleKeyInfo key = Console.ReadKey();
            //    Console.WriteLine("\nKey Pressed : " + key.Key);
            //}

            //int val = Console.Read();
            //Console.WriteLine("val = "+val);

            int a = 10, b = 20;
            a = a ^ b;
            b= a ^ b;
            a = a ^ b;
            //String Interpolation
            Console.WriteLine($"a = { a }");//20
            Console.WriteLine($"b = { b }");//10
        }

        static double convertToCelsius(double f) 
        {
            return (f - 32) * 5 / 9.0;
        }
        static double convertToFarenheit(double c)
        {
            return ( ( c * 9.0 ) / 5 ) + 32;
        }
        static double calculateInrest(double p , double r , double n)
        {
            return (p * r * n) / 100.0;
        }
    }
}
