using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositAcount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acount = new BankAccount();
            acount.AccountNo = "SV-001";
            acount.CustomerName = "Parvez";
            acount.Deposit(2000);
            acount.Withdraw(1500);
            double balance = acount.Balance;



            SavingAcount sv1 = new SavingAcount();

            sv1.AccountNo = "sv-002";
            sv1.CustomerName = "hasan";
            sv1.Deposit(3000);
            sv1.Withdraw(2000);

            

            CheckingAccount ch1 = new CheckingAccount();
            ch1.AccountNo ="ch-2020";
            ch1.CustomerName = "Maruf";
            ch1.Deposit(5000);
            ch1.Withdraw(1000);

            Console.ReadKey();
        }
    }
}
