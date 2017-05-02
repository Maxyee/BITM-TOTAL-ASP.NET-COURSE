using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositAcount
{
    class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }


        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
    }
}
