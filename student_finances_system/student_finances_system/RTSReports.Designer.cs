namespace student_finances_system
{
    partial class RTSReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexelreport = new System.Windows.Forms.Button();
            this.cmbStartMonth = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblStartMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbEndMonth = new System.Windows.Forms.ComboBox();
            this.lblEndMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(65, 246);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.Size = new System.Drawing.Size(1049, 176);
            this.ReportDataGrid.TabIndex = 29;
            this.ReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnexelreport);
            this.panel1.Controls.Add(this.cmbStartMonth);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.lblStartMonth);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.cmbYear);
            this.panel1.Controls.Add(this.cmbEndMonth);
            this.panel1.Controls.Add(this.lblEndMonth);
            this.panel1.Location = new System.Drawing.Point(65, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 100);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnexelreport
            // 
            this.btnexelreport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexelreport.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexelreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexelreport.Location = new System.Drawing.Point(887, 12);
            this.btnexelreport.Margin = new System.Windows.Forms.Padding(2);
            this.btnexelreport.Name = "btnexelreport";
            this.btnexelreport.Size = new System.Drawing.Size(143, 69);
            this.btnexelreport.TabIndex = 26;
            this.btnexelreport.Text = "XML REPORT";
            this.btnexelreport.UseVisualStyleBackColor = false;
            this.btnexelreport.Click += new System.EventHandler(this.btnexelreport_Click);
            // 
            // cmbStartMonth
            // 
            this.cmbStartMonth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbStartMonth.Location = new System.Drawing.Point(29, 19);
            this.cmbStartMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStartMonth.Name = "cmbStartMonth";
            this.cmbStartMonth.Size = new System.Drawing.Size(200, 29);
            this.cmbStartMonth.TabIndex = 23;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(692, 12);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(152, 69);
            this.btnGenerate.TabIndex = 25;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblStartMonth
            // 
            this.lblStartMonth.AutoSize = true;
            this.lblStartMonth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartMonth.Location = new System.Drawing.Point(25, 67);
            this.lblStartMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartMonth.Name = "lblStartMonth";
            this.lblStartMonth.Size = new System.Drawing.Size(125, 21);
            this.lblStartMonth.TabIndex = 21;
            this.lblStartMonth.Text = "Starting Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(346, 67);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 21);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(523, 20);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(144, 29);
            this.cmbYear.TabIndex = 24;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbEndMonth
            // 
            this.cmbEndMonth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbEndMonth.Location = new System.Drawing.Point(247, 20);
            this.cmbEndMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEndMonth.Name = "cmbEndMonth";
            this.cmbEndMonth.Size = new System.Drawing.Size(200, 29);
            this.cmbEndMonth.TabIndex = 22;
            this.cmbEndMonth.SelectedIndexChanged += new System.EventHandler(this.cmbEndMonth_SelectedIndexChanged);
            // 
            // lblEndMonth
            // 
            this.lblEndMonth.AutoSize = true;
            this.lblEndMonth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndMonth.Location = new System.Drawing.Point(195, 67);
            this.lblEndMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndMonth.Name = "lblEndMonth";
            this.lblEndMonth.Size = new System.Drawing.Size(119, 21);
            this.lblEndMonth.TabIndex = 19;
            this.lblEndMonth.Text = "Ending Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 40);
            this.label1.TabIndex = 30;
            this.label1.Text = "RTS REPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            // 
            // RTSReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "RTSReports";
            this.Size = new System.Drawing.Size(1184, 425);
            this.Load += new System.EventHandler(this.RTSReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexelreport;
        private System.Windows.Forms.ComboBox cmbStartMonth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblStartMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbEndMonth;
        private System.Windows.Forms.Label lblEndMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
