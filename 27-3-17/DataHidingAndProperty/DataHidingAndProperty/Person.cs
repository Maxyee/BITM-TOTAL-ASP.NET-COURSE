using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHidingAndProperty
{
    class Person
    {
        private string firstName;
        public string middleName;

        public string LastName { get; set; } // auto property.

        public string FirstName             // read or write property 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public void SetMiddleName(string fname)
        {
            middleName = fname;
        }

        public string GetMiddleName()
        {
            return middleName;
        }
    }
}
