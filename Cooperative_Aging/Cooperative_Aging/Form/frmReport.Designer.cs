namespace Cooperative_Aging.Form
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cooperativeDataSet = new Cooperative_Aging.cooperativeDataSet();
            this.cooperativeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new Cooperative_Aging.Form.DataSet1();
            this.allLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allLoansTableAdapter = new Cooperative_Aging.Form.DataSet1TableAdapters.allLoansTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new Cooperative_Aging.Form.DataSet1TableAdapters.DataTable1TableAdapter();
            this.membersinfoTableAdapter = new Cooperative_Aging.Form.DataSet1TableAdapters.membersinfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(23, 506);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(86, 37);
            this.metroTextButton1.TabIndex = 1;
            this.metroTextButton1.Text = "Generate";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(23, 79);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 2;
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(810, 14);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(75, 23);
            this.metroTextButton2.TabIndex = 3;
            this.metroTextButton2.Text = "X";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // cooperativeDataSet
            // 
            this.cooperativeDataSet.DataSetName = "cooperativeDataSet";
            this.cooperativeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cooperativeDataSetBindingSource
            // 
            this.cooperativeDataSetBindingSource.DataSource = this.cooperativeDataSet;
            this.cooperativeDataSetBindingSource.Position = 0;
            this.cooperativeDataSetBindingSource.CurrentChanged += new System.EventHandler(this.cooperativeDataSetBindingSource_CurrentChanged);
            // 
            // membersinfoBindingSource
            // 
            this.membersinfoBindingSource.DataMember = "membersinfo";
            this.membersinfoBindingSource.DataSource = this.cooperativeDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "allLoans";
            reportDataSource1.Value = this.allLoansBindingSource;
            reportDataSource2.Name = "Test_Datasets";
            reportDataSource2.Value = this.DataTable1BindingSource;
            reportDataSource3.Name = "membersinfo";
            reportDataSource3.Value = this.membersinfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cooperative_Aging.Form.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(862, 386);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allLoansBindingSource
            // 
            this.allLoansBindingSource.DataMember = "allLoans";
            this.allLoansBindingSource.DataSource = this.DataSet1;
            // 
            // allLoansTableAdapter
            // 
            this.allLoansTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // membersinfoTableAdapter
            // 
            this.membersinfoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 557);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroTextButton2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroTextButton1);
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        private cooperativeDataSet cooperativeDataSet;
        private System.Windows.Forms.BindingSource cooperativeDataSetBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource membersinfoBindingSource;
        private System.Windows.Forms.BindingSource allLoansBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1TableAdapters.allLoansTableAdapter allLoansTableAdapter;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private DataSet1TableAdapters.membersinfoTableAdapter membersinfoTableAdapter;
    }
}