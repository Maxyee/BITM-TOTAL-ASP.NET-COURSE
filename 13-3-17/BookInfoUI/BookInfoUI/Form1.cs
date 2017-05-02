using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoUI
{
    public partial class Form1 : Form
    {
        ArrayList myArrayList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myArrayList.Add(txtAddBook.Text);
            txtAddBook.Text = string.Empty;
            foreach (string VARIAB in myArrayList)
            {
                
            }
            lstAddBook.Items.Add(txtAddBook.Text);
        }
    }
}
