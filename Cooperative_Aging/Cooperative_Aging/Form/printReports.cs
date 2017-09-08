using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooperative_Aging.Form
{
    public partial class printReports : MetroFramework.Forms.MetroForm
    {
        public printReports()
        {
            InitializeComponent();
        }

        private void printReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cooperativeDataSet.membersinfo' table. You can move, or remove it, as needed.
            this.membersinfoTableAdapter.Fill(this.cooperativeDataSet.membersinfo);

            this.reportViewer1.RefreshReport();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
