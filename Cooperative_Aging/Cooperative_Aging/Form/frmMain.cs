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
        string sampleAgingDatabase = "server=localhost;database=sample_aging;Persist Security Info = True; User Id=root; password=root";


        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection MyConn = new MySqlConnection(connString);
            //dTime.MaxDate = DateTime.Now;
            metroLabel10.Text = DateTime.Now.ToShortDateString();

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
            string querytypeofLoans = "SELECT loancode, duration, concat(loancode,', ',description) AS loans FROM typeofloans";
            MySqlCommand loanCom = new MySqlCommand(querytypeofLoans, MyConn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(loanCom);
            da2.Fill(typeofloansTable);

            cbtypeofLoans.DataSource = typeofloansTable;
            cbtypeofLoans.DisplayMember = "loans";
            cbtypeofLoans.ValueMember = "duration";


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
                MySqlConnection MyConn = new MySqlConnection(sampleAgingDatabase);

                metroGrid1.Rows.Clear();
                string currentDate = this.metroLabel10.Text;
                DateTime currentdatee = DateTime.Parse(currentDate);
                //

                string dueDateloans = dueDate.Value.ToShortDateString();
                DateTime dueDateloanss = DateTime.Parse(dueDateloans);

                TimeSpan getdays = currentdatee - dueDateloanss;
                // int getdayss = getdays;
                //MessageBox.Show(getdays.Days.ToString());

                /////CALCULATION STARTS HERE
                string loanDuration = cbtypeofLoans.SelectedValue.ToString(); //getting the value/duration of the selected type of loan. for example output: 12
                int loanDuration1 = Int32.Parse(loanDuration); //then converted to int

                Double prLoan = Convert.ToDouble(tbBalance.Text);

                //interest calculation in EMERGENCY LOAN
                Double interestRate = 6; //not permanent value '6'
                Double interest = Math.Round((prLoan * (interestRate / 100)) / (loanDuration1-6), 2); // loan duration minus 6 months. because that's where the interest start blablablabla

                //// for example input and output:::: 
                ////(60000 * 0.06 / 12 )+ (60000 /12)
                ///=3600/12 = 300 + 5000 = 5300 -- this is the monthly amortization or the monthly pay
                Double monthlyAmort = Math.Round(((prLoan * (interestRate / 100)) / /*12*/loanDuration1) + prLoan / /*12*/loanDuration1, 2); // a every month pay of your loans, it calculates by dividing the amount loan and the months to pay the loan. blablabla
                Double principalAmount = Math.Round(((prLoan * (interestRate / 100)) / /*12*/loanDuration1) + prLoan / /*12*/loanDuration1, 2); // the same with the monthlyamort, i just made this to made the calculation of the principal amount after 6mons. blablabla
                //MessageBox.Show(Convert.ToString(interest));



                for (int x = 1; x <= loanDuration1 /*12*/; x++)
                {
                    DateTime firstMonth = DateTime.Parse(dTime.Value.AddMonths(1).ToShortDateString()); //nopay for 1st month
                    string dueDate = firstMonth.AddMonths(x).ToShortDateString(); // the month where to start the paytime// this increment the month by 1
                    //MessageBox.Show(dueDate);
                    int rowId = metroGrid1.Rows.Add();
                    // Grab the new row!
                    DataGridViewRow row = metroGrid1.Rows[rowId];

                    // Add the data
                    row.Cells["Full_Name"].Value = cbName.Text;
                    row.Cells["Due_Date"].Value = dueDate;
                    row.Cells["Amount_Granted"].Value = prLoan.ToString("#,##0.00");
                    row.Cells["Monthly_Amortization"].Value = monthlyAmort.ToString("#,##0.00");
                    row.Cells["Principal_Amount"].Value = principalAmount.ToString("#,##0.00");
                    row.Cells["Amount_Paid"].Value = "0";
                    row.Cells["Amount_Not_Paid"].Value = "0";

                    Double getBalance = prLoan - (principalAmount * x);
                    row.Cells["Running_Balance"].Value = getBalance.ToString("#,##0.00");

                    if (x >= 7) //month where to start the interest
                    {
                        //calculation to descrease the principal from interest after 6mons
                        Double principalMinusInterest = principalAmount - interest;
                        row.Cells["Principal_Amount"].Value = principalMinusInterest.ToString("#,##0.00");

                        row.Cells["Interest"].Value = interest.ToString("#,##0.00");

                        Double getBalance2 = (prLoan - (monthlyAmort * 6)); // get the balance after 6mons
                        Double withInterest = (getBalance2 - (principalMinusInterest * (x - 6))); //decrement running balance with interest
                        row.Cells["Running_Balance"].Value = withInterest.ToString("#,##0.00");


                    }

                    Double sumMonthly = 0;
                    Double sumPrincipal = 0;
                    Double sumInterest = 0;
                    for (int i = 0; i < metroGrid1.Rows.Count; i++)
                    {
                        sumMonthly += Convert.ToDouble(metroGrid1.Rows[i].Cells["Monthly_Amortization"].Value);
                        sumPrincipal += Convert.ToDouble(metroGrid1.Rows[i].Cells["Principal_Amount"].Value);
                        sumInterest += Convert.ToDouble(metroGrid1.Rows[i].Cells["Interest"].Value);
                    }
                    totalMonthly.Text = sumMonthly.ToString("#,##0.00");
                    totalPrincipal.Text = sumPrincipal.ToString("#,##0.00");
                    totalInterest.Text = sumInterest.ToString("#,##0.00");

                    /////CALCULATION ENDS HERE

                }

                Double grossloan = Convert.ToDouble(tbBalance.Text);
                // CODE OUTPUT OF LABELS STARTS HERE
                lbfullName.Text = cbName.Text;
                lbtypeofLoans.Text = cbtypeofLoans.Text;
                lbdateGranted.Text = dTime.Text;
                lbgrossLoan.Text = grossloan.ToString("#,##0.00"); 
                lbInterest.Text = "%6"; //default interest but not yet sure if this is permanent. need to improve
                lbmonthAmort.Text = monthlyAmort.ToString("#,##0.00");
                lbtotalAmort.Text = totalMonthly.Text;
                lbtotalPrincipal.Text = totalPrincipal.Text;
                lbtotalInterest.Text = totalInterest.Text;

                //SHOW LABELS AFTER GENERATE
                lbfullName.Visible = true;
                lbtypeofLoans.Visible = true;
                lbdateGranted.Visible = true;
                lbgrossLoan.Visible = true;
                lbInterest.Visible = true;
                lbmonthAmort.Visible = true;
                lbtotalAmort.Visible = true;
                lbtotalPrincipal.Visible = true;
                lbtotalInterest.Visible = true;
                //CODE OUTPUT OF LABELS ENDS HERE


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
            Form.printReports report = new Form.printReports();
            report.ShowDialog();

        }

        
        private void dTime_ValueChanged(object sender, EventArgs e)
        {
            
            string loanDuration = cbtypeofLoans.SelectedValue.ToString();
            //MessageBox.Show(dTime.Value.ToShortDateString() + "Now");
            string dueDate1 = dTime.Value.AddMonths(Int32.Parse(loanDuration)+1).ToShortDateString();
            //MessageBox.Show(dueDate1 + "Expired");

            dueDate.Text = dueDate1;
        }

        private void cbtypeofLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbtypeofLoans.SelectedValue.ToString());
        }
    }
}
