namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = Convert.ToString(textBox1.Text);
            string name = Convert.ToString(textBox2.Text);
            string lastName = Convert.ToString(textBox3.Text);

            textBox6.Text += Environment.NewLine + " Фамилия:" + firstName;
            textBox6.Text += Environment.NewLine + " Имя:" + name;
            textBox6.Text += Environment.NewLine + " Отчество:" + lastName;

            if (radioButton1.Checked)
            {
                textBox6.Text += Environment.NewLine + "Пол: " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                textBox6.Text += Environment.NewLine + "Пол: " + radioButton2.Text;
            }

            textBox6.Text += Environment.NewLine + "Дата рождения: " + comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text;

            textBox6.Text += Environment.NewLine + "Место проживания: " + comboBox4.Text;

            textBox6.Text += Environment.NewLine + "Адрес электронной почты: " + textBox4.Text;

            textBox6.Text += Environment.NewLine + "Мобильный телефон: " + comboBox5.Text + " " + textBox5.Text;

            if (radioButton3.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыт работы: " + radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыт работы: " + radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыт работы: " + radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыт работы: " + radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                textBox6.Text += Environment.NewLine + "Опыт работы: " + radioButton7.Text;
            }

            if (checkBox1.Checked)
            {
                textBox6.Text += Environment.NewLine + "Есть личное авто";
            }
            else
            {
                textBox6.Text += Environment.NewLine + "Нет личное авто";
            }

            if (checkBox2.Checked)
            {
                textBox6.Text += Environment.NewLine + "Есть водительское удостоверение";
            }
            else
            {
                textBox6.Text += Environment.NewLine + "Нет водительского удостоверения";
            }

            if (checkBox3.Checked)
            {
                textBox6.Text += Environment.NewLine + "Водительская категория" + checkBox3.Text;
            }

            if (checkBox4.Checked)
            {
                textBox6.Text += Environment.NewLine + "Водительская категория" + checkBox4.Text;
            }

            if (checkBox5.Checked)
            {
                textBox6.Text += Environment.NewLine + "Водительская категория" + checkBox5.Text;
            }

            if (checkBox6.Checked)
            {
                textBox6.Text += Environment.NewLine + "Водительская категория" + checkBox6.Text;
            }

            textBox6.Text += Environment.NewLine + "Заработная плата от:" + numericUpDown1.Value + "До: " + numericUpDown2.Value;

            if (radioButton8.Checked)
            {
                textBox6.Text += Environment.NewLine + "График работы: " + radioButton8.Text;
            }
            else if (radioButton9.Checked)
            {
                textBox6.Text += Environment.NewLine + "График работы: " + radioButton9.Text;
            }
            else if (radioButton10.Checked)
            {
                textBox6.Text += Environment.NewLine + "График работы: " + radioButton10.Text;
            }
            else if (radioButton11.Checked)
            {
                textBox6.Text += Environment.NewLine + "График работы: " + radioButton11.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Close();
        }
    }
}