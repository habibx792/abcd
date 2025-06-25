namespace student_finances_system
{
    partial class AddExpense
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
            this.lblheading = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtexpensename = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lblexpensename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblheading.Location = new System.Drawing.Point(206, 74);
            this.lblheading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(201, 31);
            this.lblheading.TabIndex = 32;
            this.lblheading.Text = "Expense Form";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmit.Location = new System.Drawing.Point(427, 345);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(154, 54);
            this.btnsubmit.TabIndex = 31;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtexpensename
            // 
            this.txtexpensename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpensename.Location = new System.Drawing.Point(354, 146);
            this.txtexpensename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtexpensename.Name = "txtexpensename";
            this.txtexpensename.Size = new System.Drawing.Size(227, 30);
            this.txtexpensename.TabIndex = 30;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(354, 194);
            this.txtamount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(227, 30);
            this.txtamount.TabIndex = 29;
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(349, 291);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(232, 23);
            this.dtpdate.TabIndex = 28;
            this.dtpdate.ValueChanged += new System.EventHandler(this.dtpdate_ValueChanged);
            // 
            // cmbmonth
            // 
            this.cmbmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Items.AddRange(new object[] {
            "January",
            "Febrary",
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
            this.cmbmonth.Location = new System.Drawing.Point(349, 248);
            this.cmbmonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(232, 33);
            this.cmbmonth.TabIndex = 27;
            this.cmbmonth.SelectedIndexChanged += new System.EventHandler(this.cmbmonth_SelectedIndexChanged);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblamount.Location = new System.Drawing.Point(234, 194);
            this.lblamount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(55, 15);
            this.lblamount.TabIndex = 26;
            this.lblamount.Text = "Amount";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldate.Location = new System.Drawing.Point(234, 291);
            this.lbldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 15);
            this.lbldate.TabIndex = 25;
            this.lbldate.Text = "Date";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmonth.Location = new System.Drawing.Point(234, 248);
            this.lblmonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(47, 15);
            this.lblmonth.TabIndex = 24;
            this.lblmonth.Text = "Month";
            // 
            // lblexpensename
            // 
            this.lblexpensename.AutoSize = true;
            this.lblexpensename.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblexpensename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpensename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblexpensename.Location = new System.Drawing.Point(234, 146);
            this.lblexpensename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexpensename.Name = "lblexpensename";
            this.lblexpensename.Size = new System.Drawing.Size(104, 15);
            this.lblexpensename.TabIndex = 23;
            this.lblexpensename.Text = "Expense Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtexpensename);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lblexpensename);
            this.Name = "AddExpense";
            this.Text = "AddExpense";
            this.Load += new System.EventHandler(this.AddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtexpensename;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lblexpensename;
        private System.Windows.Forms.Label label1;
    }
}