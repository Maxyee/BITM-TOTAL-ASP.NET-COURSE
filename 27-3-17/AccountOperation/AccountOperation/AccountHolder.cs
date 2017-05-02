using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountOperation
{
    public class AccountHolder
    {
        public string accountNumber;
        public string customerName;
        public double balance;

        public void SetBalance(double newBalance)
        {
            balance = newBalance;
        }

        public double GetBalance()
        {
            return balance;
        }
        //public string accountCreate(string a, string b)
        //{
            
        //}

        public double Deposite(double amount)
        {
            balance = balance + amount;
            return balance;
        }

        public double Withdraw(double amount)
        {
            if (amount == 0)
            {
                double i = 0;
                return i;
            }
            else
            {
                balance = balance - amount;
                return balance;
            }
        }
    }
}