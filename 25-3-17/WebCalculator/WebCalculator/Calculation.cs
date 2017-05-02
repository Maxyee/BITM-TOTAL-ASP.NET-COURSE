using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalculator
{
    public class Calculation
    {
        public double AddNumber(double firstnumber, double lastnumber)
        {
            return firstnumber + lastnumber;
        }

        public double SubstactNumber(double firstnumber, double lastnumber)
        {
            return firstnumber - lastnumber;
        }

        public double MultiplicationNumber(double firstnumber, double lastnumber)
        {
            return firstnumber*lastnumber;
        }

        public double DivideNumber(double firstnumber, double lastnumber)
        {
            return firstnumber/lastnumber;
        }
    }
}