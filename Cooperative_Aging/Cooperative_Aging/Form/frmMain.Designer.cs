namespace Cooperative_Aging
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cbName = new MetroFramework.Controls.MetroComboBox();
            this.cbtypeofLoans = new MetroFramework.Controls.MetroComboBox();
            this.dTime = new MetroFramework.Controls.MetroDateTime();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton6 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton4 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbLoans = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbPayments = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton3 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbBalance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dueDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Due_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Granted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monthly_Amortization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Running_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Not_Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.Silver;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Full_Name,
            this.Due_Date,
            this.Amount_Granted,
            this.Monthly_Amortization,
            this.Principal_Amount,
            this.Interest,
            this.Running_Balance,
            this.Amount_Paid,
            this.Amount_Not_Paid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(293, 48);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(942, 377);
            this.metroGrid1.TabIndex = 3;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(12, 315);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(109, 49);
            this.metroTextButton1.TabIndex = 6;
            this.metroTextButton1.Text = "Calculate";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.ItemHeight = 23;
            this.cbName.Location = new System.Drawing.Point(12, 85);
            this.cbName.Name = "cbName";
            this.cbName.PromptText = "Type LastName Here";
            this.cbName.Size = new System.Drawing.Size(218, 29);
            this.cbName.TabIndex = 7;
            this.cbName.UseSelectable = true;
            this.cbName.SelectionChangeCommitted += new System.EventHandler(this.cbName_SelectionChangeCommitted);
            // 
            // cbtypeofLoans
            // 
            this.cbtypeofLoans.FormattingEnabled = true;
            this.cbtypeofLoans.ItemHeight = 23;
            this.cbtypeofLoans.Location = new System.Drawing.Point(12, 120);
            this.cbtypeofLoans.Name = "cbtypeofLoans";
            this.cbtypeofLoans.PromptText = "Type of Loans";
            this.cbtypeofLoans.Size = new System.Drawing.Size(218, 29);
            this.cbtypeofLoans.TabIndex = 8;
            this.cbtypeofLoans.UseSelectable = true;
            this.cbtypeofLoans.SelectedIndexChanged += new System.EventHandler(this.cbtypeofLoans_SelectedIndexChanged);
            // 
            // dTime
            // 
            this.dTime.Location = new System.Drawing.Point(12, 173);
            this.dTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dTime.Name = "dTime";
            this.dTime.Size = new System.Drawing.Size(218, 29);
            this.dTime.TabIndex = 9;
            this.dTime.ValueChanged += new System.EventHandler(this.dTime_ValueChanged);
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(1160, 19);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(75, 23);
            this.metroTextButton2.TabIndex = 13;
            this.metroTextButton2.Text = "X";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // metroTextButton6
            // 
            this.metroTextButton6.Image = null;
            this.metroTextButton6.Location = new System.Drawing.Point(12, 63);
            this.metroTextButton6.Name = "metroTextButton6";
            this.metroTextButton6.Size = new System.Drawing.Size(99, 16);
            this.metroTextButton6.TabIndex = 18;
            this.metroTextButton6.Text = "Member Info.";
            this.metroTextButton6.UseSelectable = true;
            this.metroTextButton6.UseVisualStyleBackColor = true;
            // 
            // metroTextButton4
            // 
            this.metroTextButton4.Image = null;
            this.metroTextButton4.Location = new System.Drawing.Point(1007, 438);
            this.metroTextButton4.Name = "metroTextButton4";
            this.metroTextButton4.Size = new System.Drawing.Size(111, 42);
            this.metroTextButton4.TabIndex = 16;
            this.metroTextButton4.Text = "Loans Details";
            this.metroTextButton4.UseSelectable = true;
            this.metroTextButton4.UseVisualStyleBackColor = true;
            this.metroTextButton4.Visible = false;
            this.metroTextButton4.Click += new System.EventHandler(this.metroTextButton4_Click);
            // 
            // tbLoans
            // 
            this.tbLoans.Image = null;
            this.tbLoans.Location = new System.Drawing.Point(890, 438);
            this.tbLoans.Name = "tbLoans";
            this.tbLoans.Size = new System.Drawing.Size(111, 42);
            this.tbLoans.TabIndex = 19;
            this.tbLoans.Text = "Loans";
            this.tbLoans.UseSelectable = true;
            this.tbLoans.UseVisualStyleBackColor = true;
            this.tbLoans.Visible = false;
            this.tbLoans.Click += new System.EventHandler(this.tbLoans_Click);
            // 
            // tbPayments
            // 
            this.tbPayments.Image = null;
            this.tbPayments.Location = new System.Drawing.Point(1124, 438);
            this.tbPayments.Name = "tbPayments";
            this.tbPayments.Size = new System.Drawing.Size(111, 42);
            this.tbPayments.TabIndex = 20;
            this.tbPayments.Text = "Payments";
            this.tbPayments.UseSelectable = true;
            this.tbPayments.UseVisualStyleBackColor = true;
            this.tbPayments.Visible = false;
            this.tbPayments.Click += new System.EventHandler(this.tbPayments_Click);
            // 
            // metroTextButton3
            // 
            this.metroTextButton3.Image = null;
            this.metroTextButton3.Location = new System.Drawing.Point(127, 315);
            this.metroTextButton3.Name = "metroTextButton3";
            this.metroTextButton3.Size = new System.Drawing.Size(101, 49);
            this.metroTextButton3.TabIndex = 24;
            this.metroTextButton3.Text = "Reports";
            this.metroTextButton3.UseSelectable = true;
            this.metroTextButton3.UseVisualStyleBackColor = true;
            this.metroTextButton3.Click += new System.EventHandler(this.metroTextButton3_Click);
            // 
            // tbBalance
            // 
            // 
            // 
            // 
            this.tbBalance.CustomButton.Image = null;
            this.tbBalance.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.tbBalance.CustomButton.Name = "";
            this.tbBalance.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBalance.CustomButton.TabIndex = 1;
            this.tbBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBalance.CustomButton.UseSelectable = true;
            this.tbBalance.CustomButton.Visible = false;
            this.tbBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbBalance.Lines = new string[0];
            this.tbBalance.Location = new System.Drawing.Point(12, 280);
            this.tbBalance.MaxLength = 32767;
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.PasswordChar = '\0';
            this.tbBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBalance.SelectedText = "";
            this.tbBalance.SelectionLength = 0;
            this.tbBalance.SelectionStart = 0;
            this.tbBalance.Size = new System.Drawing.Size(218, 29);
            this.tbBalance.TabIndex = 25;
            this.tbBalance.UseSelectable = true;
            this.tbBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 258);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Amount Granted";
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(12, 226);
            this.dueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(218, 29);
            this.dueDate.TabIndex = 37;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 152);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 38;
            this.metroLabel7.Text = "Date Granted";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 205);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.TabIndex = 39;
            this.metroLabel8.Text = "Due Date";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(117, 38);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(87, 19);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Today\'s Date:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(117, 57);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(115, 25);
            this.metroLabel10.TabIndex = 41;
            this.metroLabel10.Text = "metroLabel10";
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "Full_Name";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            // 
            // Due_Date
            // 
            this.Due_Date.HeaderText = "Due_Date";
            this.Due_Date.Name = "Due_Date";
            this.Due_Date.ReadOnly = true;
            // 
            // Amount_Granted
            // 
            this.Amount_Granted.HeaderText = "Amount_Granted";
            this.Amount_Granted.Name = "Amount_Granted";
            this.Amount_Granted.ReadOnly = true;
            // 
            // Monthly_Amortization
            // 
            this.Monthly_Amortization.HeaderText = "Monthly_Amortization";
            this.Monthly_Amortization.Name = "Monthly_Amortization";
            this.Monthly_Amortization.ReadOnly = true;
            // 
            // Principal_Amount
            // 
            this.Principal_Amount.HeaderText = "Principal_Amount";
            this.Principal_Amount.Name = "Principal_Amount";
            this.Principal_Amount.ReadOnly = true;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            // 
            // Running_Balance
            // 
            this.Running_Balance.HeaderText = "Running_Balance";
            this.Running_Balance.Name = "Running_Balance";
            this.Running_Balance.ReadOnly = true;
            // 
            // Amount_Paid
            // 
            this.Amount_Paid.HeaderText = "Amount_Paid";
            this.Amount_Paid.Name = "Amount_Paid";
            this.Amount_Paid.ReadOnly = true;
            // 
            // Amount_Not_Paid
            // 
            this.Amount_Not_Paid.HeaderText = "Amount_Not_Paid";
            this.Amount_Not_Paid.Name = "Amount_Not_Paid";
            this.Amount_Not_Paid.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 570);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.metroTextButton3);
            this.Controls.Add(this.tbPayments);
            this.Controls.Add(this.tbLoans);
            this.Controls.Add(this.metroTextButton6);
            this.Controls.Add(this.metroTextButton4);
            this.Controls.Add(this.metroTextButton2);
            this.Controls.Add(this.dTime);
            this.Controls.Add(this.cbtypeofLoans);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.metroTextButton1);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Form1";
            this.Text = "AGING";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroComboBox cbName;
        private MetroFramework.Controls.MetroComboBox cbtypeofLoans;
        private MetroFramework.Controls.MetroDateTime dTime;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton6;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton4;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbLoans;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbPayments;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton3;
        private MetroFramework.Controls.MetroTextBox tbBalance;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dueDate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Due_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Granted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monthly_Amortization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principal_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Running_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Not_Paid;
    }
}

