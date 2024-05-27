using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace _30_1
{
    public partial class editTableForm : Form
    {
        public SqlConnection connection = null;
        public string type = "";
        public object id = 0;
        public editTableForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "edit")
            {
                Form1 form1 = new Form1();
                string name = textBox1.Text;
                string surname = textBox2.Text;
                string secondName = textBox3.Text;
                string conn = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";
                OleDbConnection dbconn = new OleDbConnection(conn);
                dbconn.Open();

                string query = "Update Туристы " +
                    $"SET Имя={name}, Фамилия={surname}, Отчество={secondName} " +
                    $"WHERE Код_туриста = {id}";
                

                
                OleDbCommand odb1 = new OleDbCommand(query, dbconn);
                OleDbDataReader odbr = odb1.ExecuteReader();
                
                type = "";
            } else
            {
                Form1 form1 = new Form1();
                string name = textBox1.Text;
                string surname = textBox2.Text;
                string secondName = textBox3.Text;
                
                string conn = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";
                OleDbConnection dbconn = new OleDbConnection(conn);
                dbconn.Open();

               
                string query = "Insert Into Туристы " +
                    $"(Имя, Фамилия, Отчество) Values('{name}', '{surname}', '{secondName}')";

                OleDbCommand odb1 = new OleDbCommand(query, dbconn);
                OleDbDataReader odbr = odb1.ExecuteReader();
                
            }

        }
    }
}
