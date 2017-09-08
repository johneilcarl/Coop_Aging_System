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

namespace Cooperative_Aging.Form
{
    public partial class frmReport : MetroFramework.Forms.MetroForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.allLoans' table. You can move, or remove it, as needed.
            //this.allLoansTableAdapter.Fill(this.DataSet1.allLoans);
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            // TODO: This line of code loads data into the 'DataSet1.membersinfo' table. You can move, or remove it, as needed.
            this.membersinfoTableAdapter.Fill(this.DataSet1.membersinfo);

            this.reportViewer1.RefreshReport();
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cooperativeDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
