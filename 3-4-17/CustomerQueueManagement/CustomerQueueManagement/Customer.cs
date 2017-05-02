using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQueueManagement
{
    internal class Customer
    {
        public string name;
        public string complain;

        public string enQueueComplain { get; set; }

        //Queue<Customer> complains = new Queue<Customer>(); 

        //public string deQueueComplain { get; set; }
    }
}