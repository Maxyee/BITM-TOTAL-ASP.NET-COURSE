using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PractiseSession
{
    public class Person
    {
        public string firstname;
        public string middlename;
        public string lastname;

        public string FullName()
        {
            return firstname + " " + middlename + " " + lastname;
        }

        public string ReverseName()
        {
            char[] cArray = FullName().ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}