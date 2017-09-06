using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace Cooperative_Aging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connString = "server=localhost;database=cooperative;Persist Security Info = True; User Id=root; password=root";

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(connString);

            DataTable displayGrid = new DataTable();
            string displayclass = "SELECT * FROM membersinfo;";
            MySqlCommand displaytest = new MySqlCommand(displayclass, MyConn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(displaytest);
            da1.Fill(displayGrid);
            dataGridView1.DataSource = displayGrid;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MyConn = new MySqlConnection(connString);

                string Query = "INSERT INTO testtable1 (fullName) VALUES ('"
                    + this.textBox1.Text + 
                    "');";

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn);
                    MyConn.Open();
                    MyCommand2.ExecuteReader();
                    MessageBox.Show("Successfully created new patient profile!");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
