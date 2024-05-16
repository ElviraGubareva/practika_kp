using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text);
            double xk = double.Parse(textBox2.Text);
            double dx = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);
            double y = 0;
            while (Math.Abs(x0) <= Math.Abs(xk)) 
            {
                y = Math.Pow(x0, 2) + Math.Tan(5 * x0 + b / x0);
                textBox5.Text += Environment.NewLine + "x = " + x0.ToString() + " y = " + y.ToString();
                x0 += dx;
            }
        }
    }
}
