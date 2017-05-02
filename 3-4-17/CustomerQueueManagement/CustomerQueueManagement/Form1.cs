using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagement
{
    public partial class Form1 : Form
    {
        Queue<Customer> complains = new Queue<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Enqueue_Click(object sender, EventArgs e)
        {
            ListViewItem item = lstView.Items.Add((lstView.Items.Count + 1).ToString());
            Customer customer1 = new Customer();
            customer1.name = txtEnName.Text;
            customer1.complain = txtEnComplain.Text;

            complains.Enqueue(customer1);

            Customer customer2 = new Customer();
            customer2.name = txtEnName.Text;
            customer2.complain = txtEnComplain.Text;

            complains.Enqueue(customer2);

            foreach (var acomplain in complains)
            {
                lstView.Items.Add(acomplain.name);
                lstView.Items.Add(acomplain.complain);
            }

            foreach (var acomplain in complains)
            {
                //lstView.
            }
        }
    }
}

/*

Last All OOP 4 class we learned..

1. class
2. object
3. constructor
4.constructor overload
5.constructor chain 
6.property
7.method overloading
8.Inheritence
9.Runtime polymorchysom
10.Base Class, sub class
11.casting
12.static

homework -> 5 line kore per topic niye likhte hobe..

*/