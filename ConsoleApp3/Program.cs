using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program to Create a divide by zero exception and handle it.
            //Program-1
            //int a = 45;
            //int b = 0;
            //try
            //{
            //    int ans = a / b;
            //}
            //catch (Exception ex) 
            //{ 
            //    Console.WriteLine("Exeception  : "+ex.Message);
            //}
            //Console.WriteLine("All Good!");

            //Program-2
            //2. Write a program that reads 5 numbers from user. Demonstrate concept of 
            //IndexOutOfRange Exception
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length+1; i++)
            //{ 
            //    try
            //    {
            //        Console.WriteLine($"Enter the value in index {i} : ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch (Exception e) 
            //    { 
            //        Console.WriteLine(e.Message);
            //    }
            //}
            //Console.WriteLine("All Good!");

            //Program-3
            //3.Write a program to create an abstract class Sum having abstract methods
            //SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c). Create another
            //class Calculate which extends the abstract class and implements the abstract methods
            //Calculate clc = new Calculate();
            //Console.WriteLine($"34 + 56 = {clc.SumOfTwo(34,56)}");
            //Console.WriteLine($"87 + 36 + 78 = {clc.SumOfThree(87, 36, 78)}");

            //Program-4
            //Write a program to create interface Calculate. In this interface we have two 
            //member functions Addition() and Subtraction(). Implements this interface
            //in another class named Result.
            //Result r = new Result();
            //Console.WriteLine($"87 + 56 = {r.addition(34, 56)}");
            //Console.WriteLine($"87 - 56 = {r.substraction(87,56)}");

            //Program-5
            //5. Write program showing use of common methods of String class.
            //String str = "Vishal Baraiya";
            //Console.WriteLine(str.ToUpper());   // Outputs "VISHAL BARAIYA"
            //Console.WriteLine(str.ToLower());   // Outputs "vishal baraiya"
            //Console.WriteLine(str.Substring(0,6)); // "Vishal"
            //Console.WriteLine(str.Contains("Vishal")); // "True"
            //Console.WriteLine(str.Length);
            //String str1 = "Hello";
            //String str2 = "World!";
            //Console.WriteLine(string.Concat(str1," ",str2));
            //Console.WriteLine(str1.IndexOf("ll"));
            //Console.WriteLine(str1.LastIndexOf("ll"));
            //Console.WriteLine(str1.IsNormalized());

            //6. Write a program to Replace lower case characters to upper case and Vice - versa.
            //Console.WriteLine("Enter the String : ");
            //String str = Console.ReadLine();//Vishal
            //char [] ch = new char[str.Length];
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (char.IsUpper(str[i]))
            //    {
            //        ch[i] = char.ToLower(str[i]);
            //    }
            //    else if (char.IsLower(str[i]))
            //    {
            //        ch[i] = char.ToUpper(str[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong Input!");
            //    }
            //}
            //Console.WriteLine(ch);//vISHAL
            //String temp = new string(ch);
            //Console.WriteLine(temp);//vISHAL

            //Program-7
            //7.Write a program to create interface named Shape.In this interface, we
            //have three methods Circle(), Triangle() and Square() which calculates area
            //of Circle, Triangle and Square respectively.Implement Shape interface.
            //Area a = new Area();
            //Console.WriteLine($"The area of Circle for ( r = 7 ) : {a.Circle(7)}");
            //Console.WriteLine($"The area of Triangle for ( h = 17 , b = 23 ) : {a.Triangle(17,23)}");
            //Console.WriteLine($"The area of Square for ( l = 7 ) : {a.Square(7)}");

            //Program-8
            //8. Write a program to accept a number from the user and throw an exception 
            //if the number is not an even number
            //Console.WriteLine("Enter the Number : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    if (n % 2 == 0)
            //    {
            //        throw new Exception("n is Even Number");// e.Message
            //    }
            //    else
            //    {
            //        Console.WriteLine("N is Odd Number");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Good Bye!");
            //}

            //Program-9
            //9. Write a program to find the longest word in a string.
            //string str = "My name is Vishalbhai Baraiya.";
            //string [] strArr = str.Split(' ');
            //int max = 0;
            //String maxStr = "";
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    if (strArr[i].Length >= max)
            //    {
            //        max = strArr[i].Length;
            //        maxStr = strArr[i];
            //    }
            //}
            //Console.WriteLine(maxStr);

            //Program-10
            //10. Write a program to change the case of entered character.
            //Console.WriteLine("Enter the Alphabet : ");
            //char ch = Convert.ToChar(Console.ReadLine());
            //if (char.IsUpper(ch)) 
            //{
            //    ch = char.ToLower(ch);
            //    Console.WriteLine(ch);
            //}
            //else if (char.IsLower(ch))
            //{
            //    ch = char.ToUpper(ch);
            //    Console.WriteLine(ch);
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Input!");
            //}
        }
    }
}
