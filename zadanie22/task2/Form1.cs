namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);

            textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При B = " + textBox3.Text + Environment.NewLine;

            double check = x * b;
            double answer = 0;

            if ((0.5 < check) && (10 > check))
            {
                answer = Math.Exp(Math.Pow(x, 2) - Math.Abs(b));
            }
            else
            {
                if ((0.1 < check) && (0.5 > check))
                {
                    answer = Math.Sqrt(Math.Abs(Math.Pow(x, 2) + b));
                }
                else
                {
                    answer = 2 * Math.Pow(Math.Pow(x, 2), 2);
                }
            }


            textBox4.Text += Environment.NewLine + " G = " + answer.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}