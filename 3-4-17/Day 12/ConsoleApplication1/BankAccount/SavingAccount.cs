using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingAccount:BankAccount
    {
        public double InterestAmount { get; set; }

        public override string Withdraw(double amount)
        {
            if (Balance - amount > 0)
            {
                base.Withdraw(1000);
             
            }
            return "withdraw";
        }
       
    }
}
