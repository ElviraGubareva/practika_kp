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

namespace task8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4; // Кол-во строк
            dataGridView1.ColumnCount = 3; // Кол-во столбцов
            int[,] a = new int[4, 3]; // Инициализируем массив
            int i, j;

            Random rand = new Random();
            for (i = 0; i < 4; i++)
                for (j = 0; j < 3; j++)
                    a[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 4; i++)
                for (j = 0; j < 3; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            int count = 0;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 3; j++)
                    if (a[i, j] > 0) count++;

            textBox1.Text = count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
