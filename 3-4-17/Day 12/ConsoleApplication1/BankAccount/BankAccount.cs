using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public string CustomerName { get; set; }
        public string  AccountNo { get; set; }
        public double Balance{ get; private set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "deposited";
        }
        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw";
        }
      
    }
}
