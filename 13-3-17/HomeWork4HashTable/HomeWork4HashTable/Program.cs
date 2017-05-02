using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("111", "ASP.NET MVC");
            aHashtable.Add("222", "Java BAsic");
            aHashtable.Add("101", "Laravel");
            aHashtable.Add("102", "Zend");
            aHashtable.Add("987", "SEO");
            string courseName = (string) aHashtable["101"];
            Console.WriteLine(courseName);
            Console.ReadKey();
        }
    }
}
