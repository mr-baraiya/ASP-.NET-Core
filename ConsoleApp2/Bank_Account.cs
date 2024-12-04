using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Write a pogram to Create a class Bank_Account with Account_No, Email,
//User_Name, Account_Type and Account_Balance as data members. Also 
//create a Member function GetAccountDetails() & DisplayAccountDetails().

namespace ConsoleApp2
{
    internal class Bank_Account
    {
        public int accountNo;
        public String userName;
        public String email;
        public String accountType;
        public double accountBalance;

        public void getAccountDetails()
        {
            Console.WriteLine("Enter the AcoountNo : ");
            accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the UserName : ");
            userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enetr the Email : ");
            email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the AcoountType : ");
            accountType = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the AccountBalance : ");
            accountBalance = Convert.ToDouble(Console.ReadLine());
        }
        public void displayAccountDetails()
        {
            Console.WriteLine("AccountNo : " + accountNo);
            Console.WriteLine("UserName : " + userName);
            Console.WriteLine("Email : " + email);
            Console.WriteLine("AccountType : " + accountType);
            Console.WriteLine("AccountBalance : " + accountBalance);
        }
    }
}
