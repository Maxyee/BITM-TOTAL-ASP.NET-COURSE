using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineAppPersonUI
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public string FathersName;
        public string MothersName;
        public string Address;

        public string ShowAllData(string a, string b , string c, string d, string e)
        {
            return "1st Name :" + a + "\n lastname :" + b + " \n Father : " + c + "\n Mother " + d + " \n Address" + e;
        }

        public string ParentName(string fa, string ma)
        {
            return "Father : " + fa + " \n Mother: " + ma;
        }

        public string thikana(string ad)
        {
            return "Address : " + ad;
        }

        public string naam(string fi, string la)
        {
            return "FirstName :" + fi + "\n" + "LastName : " + la;
        }
    }
}
