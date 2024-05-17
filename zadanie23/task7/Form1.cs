using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task7
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[30];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = Mas.Where(x => x < 0 && x % 2 != 0).Sum();
            label1.Text = "сумма элементов, которые нечетны и отрицательны: " + sum.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
