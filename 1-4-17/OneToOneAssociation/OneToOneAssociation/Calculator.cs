using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneAssociation
{
    class Calculator
    {
        public double Add(double firstNo, double secondNo)
        {
            double total = firstNo + secondNo;
            return total;
        }

        public double Add(double firstNo, double secondNo, double other)
        {
            double total = firstNo + secondNo + other;
            return total;
        }
    }
}
