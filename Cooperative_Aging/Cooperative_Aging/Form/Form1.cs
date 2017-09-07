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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connString = "server=localhost;database=cooperative;Persist Security Info = True; User Id=root; password=root";


        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection MyConn = new MySqlConnection(connString);
            dTime.MaxDate = DateTime.Now;

            // display the list of names
            DataTable nameTable = new DataTable();
            string queryName = "SELECT memberid, concat(lastName,', ',firstName,' ',middleName) AS fullName FROM membersinfo ORDER BY fullName ASC";
            MySqlCommand nameCom = new MySqlCommand(queryName, MyConn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(nameCom);
            da1.Fill(nameTable);

            cbName.DataSource = nameTable;
            cbName.DisplayMember = "fullName";
            cbName.ValueMember = "memberid";

            //displays the list of type of loans
            DataTable typeofloansTable = new DataTable();
            string querytypeofLoans = "SELECT loancode, concat(loancode,', ',description) AS loans FROM typeofloans";
            MySqlCommand loanCom = new MySqlCommand(querytypeofLoans, MyConn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(loanCom);
            da2.Fill(typeofloansTable);

            cbtypeofLoans.DataSource = typeofloansTable;
            cbtypeofLoans.DisplayMember = "loans";
            cbtypeofLoans.ValueMember = "loancode";


            cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MyConn = new MySqlConnection(connString);

                /* string Query = "INSERT INTO testtable1 (fullName) VALUES ('"
                     + this.metroTextBox1.Text +
                     "');";

                 MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn);
                 MyConn.Open();
                 MyCommand2.ExecuteReader();
                 MessageBox.Show("Successfully created new patient profile!");
                 MyConn.Close();
                 */

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbName_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }


        private void tbLoans_Click(object sender, EventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(connString);

            DataTable displayGrid = new DataTable();
            string displayclass = "SELECT * FROM loanstable WHERE memberid = '" + cbName.SelectedValue + "'";
            MySqlCommand displaytest = new MySqlCommand(displayclass, MyConn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(displaytest);
            da1.Fill(displayGrid);
            metroGrid1.DataSource = displayGrid;
        }

        private void tbPayments_Click(object sender, EventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(connString);

            DataTable displayGrid = new DataTable();
            string displayclass = "SELECT * FROM payments WHERE memberid = '" + cbName.SelectedValue + "'";
            MySqlCommand displaytest = new MySqlCommand(displayclass, MyConn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(displaytest);
            da1.Fill(displayGrid);
            metroGrid1.DataSource = displayGrid;
        }

        private void metroTextButton4_Click(object sender, EventArgs e)
        {
            
            try
            {
                string getID = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();//it will get the value on the first row in the selected row on datagridview
                MySqlConnection MyConn = new MySqlConnection(connString);

                DataTable displayGrid = new DataTable();
                string displayclass = "SELECT * FROM loandetails WHERE loanid = '" + getID + "'";
                MySqlCommand displaytest = new MySqlCommand(displayclass, MyConn);
                MySqlDataAdapter da1 = new MySqlDataAdapter(displaytest);
                da1.Fill(displayGrid);
                metroGrid1.DataSource = displayGrid;
            }
            catch (Exception)
            {
                MessageBox.Show("No Selected Loans");
            }

        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            Form.frmReport report = new Form.frmReport();
            report.ShowDialog();

        }
    }
}
