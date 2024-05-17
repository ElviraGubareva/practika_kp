using System;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace task_4
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
            string enteredSymbol = textBox1.Text.ToLower();

            int xCord = Convert.ToInt32(textBox2.Text);
            int yCord = Convert.ToInt32(textBox3.Text);

            if (enteredSymbol == "к")
            {
                Button button = new Button();
                button.Left = xCord;
                button.Top = yCord;
                button.Text = "Кнопка";
                this.Controls.Add(button);
                button.MouseMove += (sndr, evt) => (sndr as Control).Dispose();
            }

            if(enteredSymbol == "п")
            {
                TextBox txtbox = new TextBox();
                txtbox.Left = xCord;
                txtbox.Top = yCord;
                txtbox.Text = "textBox";
                this.Controls.Add(txtbox);
                txtbox.MouseMove += (sndr, evt) => (sndr as Control).Dispose();
            }

            if(enteredSymbol == "м")
            {
                Label label = new Label();
                label.Text = "Метка";
                label.Left = xCord;
                label.Top = yCord;
                this.Controls.Add(label);
               label.MouseMove += (sndr, evt) => (sndr as Control).Dispose();
            }


        }
    }
}
