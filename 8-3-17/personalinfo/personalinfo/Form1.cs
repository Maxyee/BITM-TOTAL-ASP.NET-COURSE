﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalinfo
{
    

    public partial class Form1 : Form
    {
        private string firstname;
        private string lastname;
        private string address;
        private string fathername;
        private string mothername;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            firstname = textBox1.Text;
            lastname = textBox2.Text;
            fathername = textBox3.Text;
            mothername = textBox4.Text;
            address = textBox5.Text;

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = firstname;
            textBox2.Text = lastname;
            textBox3.Text = fathername;
            textBox4.Text = mothername;
            textBox5.Text = address;

            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = firstname;
            textBox2.Text = lastname;

            textBox1.Show();
            textBox2.Show();

            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = fathername;
            textBox4.Text = mothername;

            textBox3.Show();
            textBox4.Show();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = address;
            
            textBox5.Show();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
