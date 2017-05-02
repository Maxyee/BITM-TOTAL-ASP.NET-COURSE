using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineApp
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string FathertName;
        public string MotherName;
        public string Address;

        public string GetFullName(string a , string b)
        {
            return a + b;
        }
    }
}
