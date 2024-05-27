using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_1
{
    public partial class Form1 : Form
    {

        public SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string conn = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";
            OleDbConnection dbconn = new OleDbConnection(conn);
            dbconn.Open();

            string query1 =  "Select * from Туры";
            string query2 = "Select * from Туристы";
            OleDbCommand odb1 = new OleDbCommand(query1, dbconn);
            OleDbCommand odb2 = new OleDbCommand(query2, dbconn);


            OleDbDataReader odbr = odb1.ExecuteReader();
            OleDbDataReader odbr1 = odb2.ExecuteReader();
            while (odbr.Read())
            {
                dataGridView1.Rows.Add(odbr["Код_тура"], odbr["Название"], odbr["Цена"], odbr["Информация"]);
            }
            while (odbr1.Read())
                dataGridView2.Rows.Add(odbr1["Код_туриста"], odbr1["Имя"], odbr1["Фамилия"], odbr1["Отчество"]);

          

        }




        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            editTableForm editTableForm = new editTableForm();
            editTableForm.type = "";
            editTableForm.connection = sqlConnection;
            editTableForm.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
  
            var currentCeil = dataGridView1.SelectedCells;
            var id = dataGridView1[0, currentCeil[0].RowIndex].Value;
            string conn = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";
            OleDbConnection dbconn = new OleDbConnection(conn);
            dbconn.Open();

            string query = "DELETE FROM Туры " + $"WHERE Код_тура = {id}";
            OleDbCommand odb1 = new OleDbCommand(query, dbconn);
            OleDbDataReader odbr = odb1.ExecuteReader();
 
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            editTableForm editTableForm = new editTableForm();
            editTableForm.type = "edit";
            var currentCeil = dataGridView2.SelectedCells;
            var id = dataGridView2[0, currentCeil[0].RowIndex].Value;
            editTableForm.id = id;

            editTableForm.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.турыTableAdapter.FillBy(this.dBTur_firmDataSet1.Туры);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.турыTableAdapter2.FillBy(this.dbDataSet.Туры);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.турыTableAdapter2.FillBy1(this.dbDataSet.Туры);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}
