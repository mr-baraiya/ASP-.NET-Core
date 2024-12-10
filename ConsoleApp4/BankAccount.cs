using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.Create a BankAccount class having constructor accepting initialBalance and
//accountHolderName.Also create Deposite() and withdraw() overloaded
//methods by which user can deposit/withdraw amount using different types
//of parameters(ex.cash, check).

namespace ConsoleApp4
{
    internal class BankAccount
    {
        double initialBalance;
        String accountHolderName;
        public BankAccount(double initialBalance , String accountHolderName)
        {
            this.initialBalance = initialBalance;
            this.accountHolderName = accountHolderName;
        }

        public void deposit(int amount)
        {
            initialBalance += amount;
            Console.WriteLine("Current Balance : "+initialBalance);
        }
        public void deposit(double amount)
        {
            initialBalance += amount;
            Console.WriteLine("Current Balance : " + initialBalance);
        }

        public void withdraw(int amount)
        {
            if(amount <= initialBalance)
            {
                initialBalance -= amount;
                Console.WriteLine("Current Balance : " + initialBalance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

        public void withdraw(double amount)
        {
            if (amount <= initialBalance)
            {
                initialBalance -= amount;
                Console.WriteLine("Current Balance : " + initialBalance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance : "+ initialBalance);
            }
        }

        public double getBalance()
        {
            return initialBalance;
        }
    }
}
