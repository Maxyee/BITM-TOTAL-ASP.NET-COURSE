using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount>bankAccounts=new List<BankAccount>();
            BankAccount account=new BankAccount();
            account.AccountNo = "AC-001";
            account.CustomerName = "Sharif";
            account.Deposit(15000);
            SavingAccount sv1=new SavingAccount();
            sv1.AccountNo = "AC-002";
            sv1.CustomerName = "Mohammad";
            sv1.Deposit(10000);
            sv1.Withdraw(8000);
            CheckingAccount chk1=new CheckingAccount();
            chk1.AccountNo = "AC-003";
            chk1.CustomerName = "Aabduallah";
            chk1.Withdraw(15000);
           bankAccounts.Add(account);
            bankAccounts.Add(sv1);
            bankAccounts.Add(chk1);
            //foreach (BankAccount account in bankAccounts)
            //{
            //    Console.WriteLine();
            //}

        }
    }
}
