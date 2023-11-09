using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dördüncühafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            double h, r, alan, hacim; 
            
            r = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);

            hacim = r * r * h * Math.PI;
            alan = Math.PI * r * h * 2 ;

            textBox3.Text = hacim.ToString();
            textBox4.Text = alan.ToString();
           
            Console.ReadLine();



        }
    }
}
