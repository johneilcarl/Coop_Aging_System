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
            this.totalMonthly = new MetroFramework.Controls.MetroLabel();
            this.totalPrincipal = new MetroFramework.Controls.MetroLabel();
            this.totalInterest = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbfullName = new MetroFramework.Controls.MetroLabel();
            this.lbtypeofLoans = new MetroFramework.Controls.MetroLabel();
            this.lbdateGranted = new MetroFramework.Controls.MetroLabel();
            this.lbgrossLoan = new MetroFramework.Controls.MetroLabel();
            this.lbInterest = new MetroFramework.Controls.MetroLabel();
            this.lbmonthAmort = new MetroFramework.Controls.MetroLabel();
            this.lbtotalAmort = new MetroFramework.Controls.MetroLabel();
            this.lbtotalPrincipal = new MetroFramework.Controls.MetroLabel();
            this.lbtotalInterest = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.Silver;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(236, 280);
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
            this.metroGrid1.Size = new System.Drawing.Size(997, 357);
            this.metroGrid1.TabIndex = 3;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroTextButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(12, 315);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(109, 49);
            this.metroTextButton1.TabIndex = 6;
            this.metroTextButton1.Text = "Generate";
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
            this.metroTextButton2.Location = new System.Drawing.Point(1182, 0);
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
            this.metroTextButton4.Location = new System.Drawing.Point(127, 418);
            this.metroTextButton4.Name = "metroTextButton4";
            this.metroTextButton4.Size = new System.Drawing.Size(101, 42);
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
            this.tbLoans.Location = new System.Drawing.Point(127, 370);
            this.tbLoans.Name = "tbLoans";
            this.tbLoans.Size = new System.Drawing.Size(101, 42);
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
            this.tbPayments.Location = new System.Drawing.Point(127, 466);
            this.tbPayments.Name = "tbPayments";
            this.tbPayments.Size = new System.Drawing.Size(101, 42);
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
            this.Full_Name.Visible = false;
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
            this.Amount_Granted.Visible = false;
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
            // totalMonthly
            // 
            this.totalMonthly.AutoSize = true;
            this.totalMonthly.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalMonthly.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalMonthly.Location = new System.Drawing.Point(414, 640);
            this.totalMonthly.Name = "totalMonthly";
            this.totalMonthly.Size = new System.Drawing.Size(82, 19);
            this.totalMonthly.TabIndex = 42;
            this.totalMonthly.Text = "totalMonthly";
            // 
            // totalPrincipal
            // 
            this.totalPrincipal.AutoSize = true;
            this.totalPrincipal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalPrincipal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalPrincipal.Location = new System.Drawing.Point(552, 640);
            this.totalPrincipal.Name = "totalPrincipal";
            this.totalPrincipal.Size = new System.Drawing.Size(85, 19);
            this.totalPrincipal.TabIndex = 43;
            this.totalPrincipal.Text = "totalPrincipal";
            // 
            // totalInterest
            // 
            this.totalInterest.AutoSize = true;
            this.totalInterest.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalInterest.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalInterest.Location = new System.Drawing.Point(686, 640);
            this.totalInterest.Name = "totalInterest";
            this.totalInterest.Size = new System.Drawing.Size(77, 19);
            this.totalInterest.TabIndex = 44;
            this.totalInterest.Text = "totalInterest";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(408, 643);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(363, 19);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "___________________________________________________________";
            // 
            // lbfullName
            // 
            this.lbfullName.AutoSize = true;
            this.lbfullName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbfullName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbfullName.Location = new System.Drawing.Point(251, 111);
            this.lbfullName.Name = "lbfullName";
            this.lbfullName.Size = new System.Drawing.Size(104, 25);
            this.lbfullName.TabIndex = 46;
            this.lbfullName.Text = "FULL NAME";
            this.lbfullName.Visible = false;
            // 
            // lbtypeofLoans
            // 
            this.lbtypeofLoans.AutoSize = true;
            this.lbtypeofLoans.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbtypeofLoans.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbtypeofLoans.Location = new System.Drawing.Point(251, 161);
            this.lbtypeofLoans.Name = "lbtypeofLoans";
            this.lbtypeofLoans.Size = new System.Drawing.Size(140, 25);
            this.lbtypeofLoans.TabIndex = 47;
            this.lbtypeofLoans.Text = "TYPE OF LOANS";
            this.lbtypeofLoans.Visible = false;
            // 
            // lbdateGranted
            // 
            this.lbdateGranted.AutoSize = true;
            this.lbdateGranted.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbdateGranted.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbdateGranted.Location = new System.Drawing.Point(251, 208);
            this.lbdateGranted.Name = "lbdateGranted";
            this.lbdateGranted.Size = new System.Drawing.Size(139, 25);
            this.lbdateGranted.TabIndex = 48;
            this.lbdateGranted.Text = "DATE GRANTED";
            this.lbdateGranted.Visible = false;
            // 
            // lbgrossLoan
            // 
            this.lbgrossLoan.AutoSize = true;
            this.lbgrossLoan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbgrossLoan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbgrossLoan.Location = new System.Drawing.Point(516, 111);
            this.lbgrossLoan.Name = "lbgrossLoan";
            this.lbgrossLoan.Size = new System.Drawing.Size(121, 25);
            this.lbgrossLoan.TabIndex = 49;
            this.lbgrossLoan.Text = "GROSS LOAN";
            this.lbgrossLoan.Visible = false;
            // 
            // lbInterest
            // 
            this.lbInterest.AutoSize = true;
            this.lbInterest.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbInterest.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbInterest.Location = new System.Drawing.Point(516, 161);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(87, 25);
            this.lbInterest.TabIndex = 50;
            this.lbInterest.Text = "INTEREST";
            this.lbInterest.Visible = false;
            // 
            // lbmonthAmort
            // 
            this.lbmonthAmort.AutoSize = true;
            this.lbmonthAmort.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbmonthAmort.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbmonthAmort.Location = new System.Drawing.Point(516, 208);
            this.lbmonthAmort.Name = "lbmonthAmort";
            this.lbmonthAmort.Size = new System.Drawing.Size(230, 25);
            this.lbmonthAmort.TabIndex = 51;
            this.lbmonthAmort.Text = "MONTHLY AMORTIZATION";
            this.lbmonthAmort.Visible = false;
            // 
            // lbtotalAmort
            // 
            this.lbtotalAmort.AutoSize = true;
            this.lbtotalAmort.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbtotalAmort.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbtotalAmort.Location = new System.Drawing.Point(817, 111);
            this.lbtotalAmort.Name = "lbtotalAmort";
            this.lbtotalAmort.Size = new System.Drawing.Size(223, 25);
            this.lbtotalAmort.TabIndex = 52;
            this.lbtotalAmort.Text = "TOTAL MONTHLY AMORT.";
            this.lbtotalAmort.Visible = false;
            // 
            // lbtotalPrincipal
            // 
            this.lbtotalPrincipal.AutoSize = true;
            this.lbtotalPrincipal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbtotalPrincipal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbtotalPrincipal.Location = new System.Drawing.Point(817, 161);
            this.lbtotalPrincipal.Name = "lbtotalPrincipal";
            this.lbtotalPrincipal.Size = new System.Drawing.Size(235, 25);
            this.lbtotalPrincipal.TabIndex = 53;
            this.lbtotalPrincipal.Text = "TOTAL PRINCIPAL AMOUNT";
            this.lbtotalPrincipal.Visible = false;
            // 
            // lbtotalInterest
            // 
            this.lbtotalInterest.AutoSize = true;
            this.lbtotalInterest.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbtotalInterest.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbtotalInterest.Location = new System.Drawing.Point(817, 208);
            this.lbtotalInterest.Name = "lbtotalInterest";
            this.lbtotalInterest.Size = new System.Drawing.Size(144, 25);
            this.lbtotalInterest.TabIndex = 54;
            this.lbtotalInterest.Text = "TOTAL INTEREST";
            this.lbtotalInterest.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(817, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(223, 25);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "TOTAL MONTHLY AMORT.";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(516, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 25);
            this.metroLabel4.TabIndex = 56;
            this.metroLabel4.Text = "GROSS LOAN";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(251, 85);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(104, 25);
            this.metroLabel5.TabIndex = 55;
            this.metroLabel5.Text = "FULL NAME";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(817, 136);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(235, 25);
            this.metroLabel6.TabIndex = 60;
            this.metroLabel6.Text = "TOTAL PRINCIPAL AMOUNT";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(516, 136);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(87, 25);
            this.metroLabel11.TabIndex = 59;
            this.metroLabel11.Text = "INTEREST";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(251, 136);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(140, 25);
            this.metroLabel12.TabIndex = 58;
            this.metroLabel12.Text = "TYPE OF LOANS";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(817, 186);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(144, 25);
            this.metroLabel13.TabIndex = 63;
            this.metroLabel13.Text = "TOTAL INTEREST";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(516, 186);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(230, 25);
            this.metroLabel14.TabIndex = 62;
            this.metroLabel14.Text = "MONTHLY AMORTIZATION";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(251, 186);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(139, 25);
            this.metroLabel15.TabIndex = 61;
            this.metroLabel15.Text = "DATE GRANTED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 714);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lbtotalInterest);
            this.Controls.Add(this.lbtotalPrincipal);
            this.Controls.Add(this.lbtotalAmort);
            this.Controls.Add(this.lbmonthAmort);
            this.Controls.Add(this.lbInterest);
            this.Controls.Add(this.lbgrossLoan);
            this.Controls.Add(this.lbdateGranted);
            this.Controls.Add(this.lbtypeofLoans);
            this.Controls.Add(this.lbfullName);
            this.Controls.Add(this.totalPrincipal);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.totalInterest);
            this.Controls.Add(this.totalMonthly);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel3);
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
        private MetroFramework.Controls.MetroLabel totalMonthly;
        private MetroFramework.Controls.MetroLabel totalPrincipal;
        private MetroFramework.Controls.MetroLabel totalInterest;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbfullName;
        private MetroFramework.Controls.MetroLabel lbtypeofLoans;
        private MetroFramework.Controls.MetroLabel lbdateGranted;
        private MetroFramework.Controls.MetroLabel lbgrossLoan;
        private MetroFramework.Controls.MetroLabel lbInterest;
        private MetroFramework.Controls.MetroLabel lbmonthAmort;
        private MetroFramework.Controls.MetroLabel lbtotalAmort;
        private MetroFramework.Controls.MetroLabel lbtotalPrincipal;
        private MetroFramework.Controls.MetroLabel lbtotalInterest;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
    }
}

