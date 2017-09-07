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
    public partial class frmReport : MetroFramework.Forms.MetroForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
