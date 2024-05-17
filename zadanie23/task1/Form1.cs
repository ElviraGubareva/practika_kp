using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = listBox1.SelectedItem.ToString();
            int wordAmmount = word.Count(c => c >= 'а' && c <= 'я'); ;
            label1.Text = "Количество строчных русских букв: " + wordAmmount;
        }
    }
}
