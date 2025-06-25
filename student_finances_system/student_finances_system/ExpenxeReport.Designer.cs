namespace student_finances_system
{
    partial class ExpenxeReport
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbEndMonth = new System.Windows.Forms.ComboBox();
            this.lblEndMonth = new System.Windows.Forms.Label();
            this.lblExpenseReport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexelreport = new System.Windows.Forms.Button();
            this.cmbStartMonth = new System.Windows.Forms.ComboBox();
            this.lblStartMonth = new System.Windows.Forms.Label();
            this.ExpenseDataGrid = new System.Windows.Forms.DataGridView();
            this.ExpnseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbstdYear = new System.Windows.Forms.ComboBox();
            this.cmbstdEndmonth = new System.Windows.Forms.ComboBox();
            this.cmbstdStartmonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStdExel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFinalExel = new System.Windows.Forms.Button();
            this.btnGenLossProfit = new System.Windows.Forms.Button();
            this.btnStdReport = new System.Windows.Forms.Button();
            this.DatagridStd = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(652, 12);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 53);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(532, 69);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 24);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cmbYear.Location = new System.Drawing.Point(408, 23);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(177, 32);
            this.cmbYear.TabIndex = 16;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmbEndMonth
            // 
            this.cmbEndMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEndMonth.FormattingEnabled = true;
            this.cmbEndMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbEndMonth.Location = new System.Drawing.Point(216, 23);
            this.cmbEndMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEndMonth.Name = "cmbEndMonth";
            this.cmbEndMonth.Size = new System.Drawing.Size(169, 32);
            this.cmbEndMonth.TabIndex = 15;
            // 
            // lblEndMonth
            // 
            this.lblEndMonth.AutoSize = true;
            this.lblEndMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndMonth.Location = new System.Drawing.Point(244, 69);
            this.lblEndMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndMonth.Name = "lblEndMonth";
            this.lblEndMonth.Size = new System.Drawing.Size(141, 24);
            this.lblEndMonth.TabIndex = 12;
            this.lblEndMonth.Text = "Ending Month";
            // 
            // lblExpenseReport
            // 
            this.lblExpenseReport.AutoSize = true;
            this.lblExpenseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseReport.Location = new System.Drawing.Point(293, -3);
            this.lblExpenseReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpenseReport.Name = "lblExpenseReport";
            this.lblExpenseReport.Size = new System.Drawing.Size(222, 31);
            this.lblExpenseReport.TabIndex = 20;
            this.lblExpenseReport.Text = "Expense Report";
            this.lblExpenseReport.Click += new System.EventHandler(this.lblExpenseReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnexelreport);
            this.panel1.Controls.Add(this.cmbStartMonth);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.lblStartMonth);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.cmbYear);
            this.panel1.Controls.Add(this.cmbEndMonth);
            this.panel1.Controls.Add(this.lblEndMonth);
            this.panel1.Location = new System.Drawing.Point(-3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 100);
            this.panel1.TabIndex = 22;
            // 
            // btnexelreport
            // 
            this.btnexelreport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexelreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexelreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexelreport.Location = new System.Drawing.Point(782, 12);
            this.btnexelreport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexelreport.Name = "btnexelreport";
            this.btnexelreport.Size = new System.Drawing.Size(86, 52);
            this.btnexelreport.TabIndex = 18;
            this.btnexelreport.Text = "XML REPORT";
            this.btnexelreport.UseVisualStyleBackColor = false;
            this.btnexelreport.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbStartMonth
            // 
            this.cmbStartMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartMonth.FormattingEnabled = true;
            this.cmbStartMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbStartMonth.Location = new System.Drawing.Point(14, 23);
            this.cmbStartMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStartMonth.Name = "cmbStartMonth";
            this.cmbStartMonth.Size = new System.Drawing.Size(175, 32);
            this.cmbStartMonth.TabIndex = 16;
            // 
            // lblStartMonth
            // 
            this.lblStartMonth.AutoSize = true;
            this.lblStartMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartMonth.Location = new System.Drawing.Point(45, 69);
            this.lblStartMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartMonth.Name = "lblStartMonth";
            this.lblStartMonth.Size = new System.Drawing.Size(144, 24);
            this.lblStartMonth.TabIndex = 15;
            this.lblStartMonth.Text = "Starting Month";
            // 
            // ExpenseDataGrid
            // 
            this.ExpenseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpnseID,
            this.ExpenseType,
            this.Amount,
            this.Date,
            this.Month});
            this.ExpenseDataGrid.Location = new System.Drawing.Point(-2, 419);
            this.ExpenseDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExpenseDataGrid.Name = "ExpenseDataGrid";
            this.ExpenseDataGrid.RowTemplate.Height = 24;
            this.ExpenseDataGrid.ShowCellToolTips = false;
            this.ExpenseDataGrid.Size = new System.Drawing.Size(881, 100);
            this.ExpenseDataGrid.TabIndex = 21;
            this.ExpenseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ExpnseID
            // 
            this.ExpnseID.HeaderText = "ExpnseID";
            this.ExpnseID.Name = "ExpnseID";
            // 
            // ExpenseType
            // 
            this.ExpenseType.HeaderText = "ExpenceType";
            this.ExpenseType.Name = "ExpenseType";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            // 
            // cmbstdYear
            // 
            this.cmbstdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstdYear.FormattingEnabled = true;
            this.cmbstdYear.Location = new System.Drawing.Point(408, 28);
            this.cmbstdYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbstdYear.Name = "cmbstdYear";
            this.cmbstdYear.Size = new System.Drawing.Size(177, 32);
            this.cmbstdYear.TabIndex = 33;
            // 
            // cmbstdEndmonth
            // 
            this.cmbstdEndmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstdEndmonth.FormattingEnabled = true;
            this.cmbstdEndmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbstdEndmonth.Location = new System.Drawing.Point(216, 28);
            this.cmbstdEndmonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbstdEndmonth.Name = "cmbstdEndmonth";
            this.cmbstdEndmonth.Size = new System.Drawing.Size(169, 32);
            this.cmbstdEndmonth.TabIndex = 32;
            // 
            // cmbstdStartmonth
            // 
            this.cmbstdStartmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstdStartmonth.FormattingEnabled = true;
            this.cmbstdStartmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbstdStartmonth.Location = new System.Drawing.Point(11, 28);
            this.cmbstdStartmonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbstdStartmonth.Name = "cmbstdStartmonth";
            this.cmbstdStartmonth.Size = new System.Drawing.Size(175, 32);
            this.cmbstdStartmonth.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ending Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Starting Month";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(273, 144);
            this.lblReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(211, 31);
            this.lblReport.TabIndex = 27;
            this.lblReport.Text = "Student Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnStdReport);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnStdExel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbstdYear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbstdEndmonth);
            this.panel2.Controls.Add(this.cmbstdStartmonth);
            this.panel2.Location = new System.Drawing.Point(-3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 100);
            this.panel2.TabIndex = 34;
            // 
            // btnStdExel
            // 
            this.btnStdExel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStdExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdExel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStdExel.Location = new System.Drawing.Point(782, 16);
            this.btnStdExel.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdExel.Name = "btnStdExel";
            this.btnStdExel.Size = new System.Drawing.Size(86, 52);
            this.btnStdExel.TabIndex = 34;
            this.btnStdExel.Text = "XML REPORT";
            this.btnStdExel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ending Month";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(14, 16);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(175, 32);
            this.comboBox4.TabIndex = 36;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(216, 16);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(169, 32);
            this.comboBox5.TabIndex = 37;
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(408, 16);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(177, 32);
            this.comboBox6.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btnGenLossProfit);
            this.panel3.Controls.Add(this.btnFinalExel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.comboBox6);
            this.panel3.Location = new System.Drawing.Point(-3, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 100);
            this.panel3.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Sarting Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "Profit Loss Report";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnFinalExel
            // 
            this.btnFinalExel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalExel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalExel.Location = new System.Drawing.Point(782, 16);
            this.btnFinalExel.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalExel.Name = "btnFinalExel";
            this.btnFinalExel.Size = new System.Drawing.Size(86, 52);
            this.btnFinalExel.TabIndex = 41;
            this.btnFinalExel.Text = "XML REPORT";
            this.btnFinalExel.UseVisualStyleBackColor = false;
            this.btnFinalExel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenLossProfit
            // 
            this.btnGenLossProfit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenLossProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenLossProfit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenLossProfit.Location = new System.Drawing.Point(650, 16);
            this.btnGenLossProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenLossProfit.Name = "btnGenLossProfit";
            this.btnGenLossProfit.Size = new System.Drawing.Size(122, 48);
            this.btnGenLossProfit.TabIndex = 42;
            this.btnGenLossProfit.Text = "Generate";
            this.btnGenLossProfit.UseVisualStyleBackColor = false;
            // 
            // btnStdReport
            // 
            this.btnStdReport.Location = new System.Drawing.Point(660, 26);
            this.btnStdReport.Name = "btnStdReport";
            this.btnStdReport.Size = new System.Drawing.Size(75, 42);
            this.btnStdReport.TabIndex = 36;
            this.btnStdReport.Text = "generate";
            this.btnStdReport.UseVisualStyleBackColor = true;
            this.btnStdReport.Click += new System.EventHandler(this.btnStdReport_Click);
            // 
            // DatagridStd
            // 
            this.DatagridStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridStd.Location = new System.Drawing.Point(-3, 468);
            this.DatagridStd.Name = "DatagridStd";
            this.DatagridStd.Size = new System.Drawing.Size(881, 87);
            this.DatagridStd.TabIndex = 41;
            // 
            // ExpenxeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 542);
            this.Controls.Add(this.DatagridStd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblExpenseReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExpenseDataGrid);
            this.Name = "ExpenxeReport";
            this.Text = "ExpenxeReport";
            this.Load += new System.EventHandler(this.ExpenxeReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbEndMonth;
        private System.Windows.Forms.Label lblEndMonth;
        private System.Windows.Forms.Label lblExpenseReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStartMonth;
        private System.Windows.Forms.Label lblStartMonth;
        private System.Windows.Forms.DataGridView ExpenseDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpnseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.Button btnexelreport;
        private System.Windows.Forms.ComboBox cmbstdYear;
        private System.Windows.Forms.ComboBox cmbstdEndmonth;
        private System.Windows.Forms.ComboBox cmbstdStartmonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStdExel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenLossProfit;
        private System.Windows.Forms.Button btnFinalExel;
        private System.Windows.Forms.Button btnStdReport;
        private System.Windows.Forms.DataGridView DatagridStd;
    }
}