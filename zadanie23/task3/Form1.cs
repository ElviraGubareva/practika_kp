using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.Black, 10, 50, 200, 200);

            // Рисуем "экран" компьютера
            g.FillRectangle(Brushes.Blue, 30, 70, 160, 120);

            // Рисуем "клавиатуру" компьютера
            g.FillRectangle(Brushes.Gray, 30, 210, 160, 30);
        }
    }
}
