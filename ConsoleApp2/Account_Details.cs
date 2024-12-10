using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

//6.Write a program for implementing single inheritance which creates one 
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted
//from account details.

namespace ConsoleApp2
{
    internal class Account_Details
    {
        public int accountNo;
        public String Name;
        public double accountBalance;
        public double rateOfIntrest;
        public int time;

        public void getAccountDetails()
        {
            Console.WriteLine("Enter the AcoountNo : ");
            accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the AccountBalance : ");
            accountBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate Of Intrest : ");
            rateOfIntrest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time : ");
            time = Convert.ToInt32(Console.ReadLine());
        }
    }
    internal class Interest : Account_Details
    {
        public Interest()
        {
            getAccountDetails();
        }
        public double calculateIntrest()
        {
            return (accountBalance * time * rateOfIntrest)/100;
        }
    } 
}
