using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSalaryCalculator
{
    public class SalaryCalculator
    {
        //public string employee;
        //public double basicamount;
        //public double houserent;
        //public double medicalrent;

        public double totalRent;
        public double totalMedical;
        public double Result;
        public double HouseRent(double amount, double givenPercent)
        {
            totalRent = amount*(givenPercent/100);
            return totalRent;
        }

        public double MedicalRent(double amount,double givenPercent)
        {
            totalMedical = amount * (givenPercent / 100);
            return totalMedical;
        }

        public double TotalAmount(double amount)
        {
            Result = amount + totalRent + totalMedical;
            return Result;
        }
    }
}