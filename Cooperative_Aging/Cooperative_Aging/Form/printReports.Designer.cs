namespace Cooperative_Aging.Form
{
    partial class printReports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cooperativeDataSet = new Cooperative_Aging.cooperativeDataSet();
            this.cooperativeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersinfoTableAdapter = new Cooperative_Aging.cooperativeDataSetTableAdapters.membersinfoTableAdapter();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(23, 63);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(130, 29);
            this.metroTextButton1.TabIndex = 0;
            this.metroTextButton1.Text = "Generate";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(160, 63);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "membersData";
            reportDataSource2.Value = this.membersinfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cooperative_Aging.Form.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(996, 449);
            this.reportViewer1.TabIndex = 2;
            // 
            // cooperativeDataSet
            // 
            this.cooperativeDataSet.DataSetName = "cooperativeDataSet";
            this.cooperativeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cooperativeDataSetBindingSource
            // 
            this.cooperativeDataSetBindingSource.DataMember = "membersinfo";
            this.cooperativeDataSetBindingSource.DataSource = this.cooperativeDataSet;
            // 
            // membersinfoBindingSource
            // 
            this.membersinfoBindingSource.DataMember = "membersinfo";
            this.membersinfoBindingSource.DataSource = this.cooperativeDataSet;
            // 
            // membersinfoTableAdapter
            // 
            this.membersinfoTableAdapter.ClearBeforeFill = true;
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(939, 10);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(80, 23);
            this.metroTextButton2.TabIndex = 3;
            this.metroTextButton2.Text = "X";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // printReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 570);
            this.Controls.Add(this.metroTextButton2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroTextButton1);
            this.Name = "printReports";
            this.Text = "printReports";
            this.Load += new System.EventHandler(this.printReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooperativeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource membersinfoBindingSource;
        private cooperativeDataSet cooperativeDataSet;
        private System.Windows.Forms.BindingSource cooperativeDataSetBindingSource;
        private cooperativeDataSetTableAdapters.membersinfoTableAdapter membersinfoTableAdapter;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
    }
}