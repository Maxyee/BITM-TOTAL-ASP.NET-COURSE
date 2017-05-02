using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicApp
{
    class Person // class
    {
        public string firstname;   //field/instance variable
        public string middlename;
        public string lastname;
        public string id;
        public Person(string a , string b, string c):this(a,b)
        {
            //this.firstname = a;
            //this.middlename = b;
            this.lastname = c;
        }

        public Person(string a, string b)
        {
            this.firstname = a;
            this.lastname = b;
        }

        public Person()
        {
            
        }

        public string GetFullName() //method
        {
            string fullName =  firstname + " " + middlename + " " + lastname; //local variable fullName
            return fullName;
        }

        public string GetReverseName(string fullName)
        {
            //string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = string.Empty;
            for (int i =  cArray.Length - 1; i > -1;  i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
