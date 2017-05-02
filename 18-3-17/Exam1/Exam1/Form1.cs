using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class Form1 : Form
    {
        double admission_fee, monthly_tution_fee, discount_amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // decliar the value .....

            double class1 = 10000;
            double class6 = 12000;
            double class9 = 15000;

            double month_class1 = 500;
            double month_class3 = 1000;
            double month_class6 = 1500;
            double month_class9 = 2000;
            double month_class11 = 2700;



            //here is the code for which option user will selected from the combox for the admission fee .......
            if (classComboBox.SelectedIndex == 0 || classComboBox.SelectedIndex == 1 || classComboBox.SelectedIndex == 2 || classComboBox.SelectedIndex == 3)
            {
                admission_fee = class1;
            }
            else if (classComboBox.SelectedIndex == 5 || classComboBox.SelectedIndex == 6 || classComboBox.SelectedIndex == 7)
            {
                admission_fee = class6;
            }
            else if (classComboBox.SelectedIndex == 8 || classComboBox.SelectedIndex == 9 || classComboBox.SelectedIndex == 10 || classComboBox.SelectedIndex == 11)
            {
                admission_fee = class9;
            }

            //here is the code for which option user selected form the combobox for monthly fee......

            if (classComboBox.SelectedIndex == 0 || classComboBox.SelectedIndex == 1)
            {
                monthly_tution_fee = month_class1;
            }

            else if (classComboBox.SelectedIndex == 2 || classComboBox.SelectedIndex == 3 ||
                     classComboBox.SelectedIndex == 4)
            {
                monthly_tution_fee = month_class3;
            }
            else if (classComboBox.SelectedIndex == 5 || classComboBox.SelectedIndex == 6 || classComboBox.SelectedIndex == 7)
            {
                monthly_tution_fee = month_class6;
            }
            else if (classComboBox.SelectedIndex == 8 || classComboBox.SelectedIndex == 9)
            {
                monthly_tution_fee = month_class9;
            }
            else if (classComboBox.SelectedIndex == 10 || classComboBox.SelectedIndex == 11)
            {
                monthly_tution_fee = month_class11;
            }

            //Now total admission feee and monthly fee equals to---->
            double result = Calculate(admission_fee, monthly_tution_fee);


            // here is the code for the User checking or not the check box.......
            if (checkBox.Checked == true)
            {
                discount_amount = (result * 5)/100;
            }
            else if(checkBox.Checked == false)
            {
                discount_amount = 0;
            }

            //so the final result will be .... >

            double final_result = result - discount_amount;
            
            MessageBox.Show("Total Amount : " + final_result.ToString()+ ".0");
            //MessageBox.Show(String.Format ("{0:0.00}"+"Total Amount : "+final_result.ToString()));
        }

        // calculating total amount admission fee + tution fee into this function.....
        private double Calculate(double x, double y)
        {
            double total_amount = x + (y*12);
            return total_amount;
        }
    }
}
