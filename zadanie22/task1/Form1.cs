namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,01655";
            textBox2.Text = "-2,75";
            textBox3.Text = "0,15";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + " X = " + x.ToString();

            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + " Y = " + y.ToString();

            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + " Z = " + z.ToString();

            double betta = Math.Sqrt(10 * (Math.Cbrt(x) + Math.Pow(x,y+2)))*(Math.Asin(Math.Pow(z,2)) - (Math.Abs(x-y)));

            textBox4.Text += Environment.NewLine + " betta = " + betta.ToString();

        }
    }
}