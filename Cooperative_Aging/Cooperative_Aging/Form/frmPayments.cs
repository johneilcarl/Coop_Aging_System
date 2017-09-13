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
namespace Cooperative_Aging.Form
{
    public partial class frmPayments : MetroFramework.Forms.MetroForm
    {
        public frmPayments()
        {
            InitializeComponent();
        }



        string coop_database_string = "server=localhost;database=coop_database;Persist Security Info = True; User Id=root; password=root";
        

        private void frmPayments_Load(object sender, EventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(coop_database_string);
            DataTable nameTable = new DataTable();
            string queryName = "SELECT memberid, concat(lastName,', ',firstName,' ',middleName) AS fullName FROM membersinfo ORDER BY fullName ASC";
            MySqlCommand nameCom = new MySqlCommand(queryName, MyConn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(nameCom);
            da1.Fill(nameTable);

            cbfullName.DataSource = nameTable;
            cbfullName.DisplayMember = "fullName";
            cbfullName.ValueMember = "memberid";

            cbfullName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbfullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbfullName.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void cbfullName_SelectedValueChanged(object sender, EventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(coop_database_string);
            DataTable loans_datatable = new DataTable();
            string loans_table_string = "SELECT lt.id_loanstable, CONCAT(lastName,', ',firstName,' ',middleName) as Name, dateGranted AS Date_Granted, tl.description AS Description, grossLoan AS Gross_Loan, monthlyAmort AS Monthly_Amort, interest AS Interest, totalInterest AS Total_Interest FROM loanstable lt INNER JOIN typeofloans tl ON lt.id_typesofLoans = tl.loancode INNER JOIN membersinfo mi ON mi.memberid = lt.id_membersinfo WHERE lt.id_membersinfo ='" + cbfullName.SelectedValue+ "';";
            MySqlCommand loans_command = new MySqlCommand(loans_table_string, MyConn);
            MySqlDataAdapter loans_dataAdapter = new MySqlDataAdapter(loans_command);
            loans_dataAdapter.Fill(loans_datatable);
            metroGrid1.DataSource = loans_datatable;

            metroGrid1.Columns["id_loanstable"].Visible = false;
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(coop_database_string);
            string getloansID = this.metroGrid1.CurrentRow.Cells[0].Value.ToString(); //this will get the ID in the selected cell in the gridview 1

            DataTable loandetails = new DataTable();
            string loandetails_string = "SELECT ld.dueDate AS Due_Date, ld.amountGranted AS Amount_Granted, ld.monthlyAmort AS Monthly_Amort, ld.principalAmount AS Principal_Amount, ld.interestAmount AS Interest_Amount, ld.runningBalance AS Running_Balance, ld.amountPaid AS Amount_Paid, ld.amountDue AS Amount_Due FROM loansdetail ld INNER JOIN typeofloans tl ON ld.id_typesofLoans = tl.loancode WHERE ld.id_loanstable ='" + getloansID + "';";
            MySqlCommand loans_command = new MySqlCommand(loandetails_string, MyConn);
            MySqlDataAdapter loans_dataAdapter = new MySqlDataAdapter(loans_command);
            loans_dataAdapter.Fill(loandetails);

            metroGrid2.DataSource = loandetails;
        }
    }
}
