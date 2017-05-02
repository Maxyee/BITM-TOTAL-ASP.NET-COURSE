using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositAcount
{
    class SavingAcount:BankAccount
    {
        public double InterestAmount { get; set; }

      
        public override string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                return base.Withdraw(amount);

            }
            else
            {
                return "Insufficient Balance";
            }
        }
    }
}
