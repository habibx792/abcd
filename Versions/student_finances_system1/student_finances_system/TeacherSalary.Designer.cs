namespace student_finances_system
{
    partial class TeacherSalary
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
            this.txtdays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dtPay = new System.Windows.Forms.DateTimePicker();
            this.lblPaid = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtdays
            // 
            this.txtdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdays.Location = new System.Drawing.Point(359, 286);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(240, 30);
            this.txtdays.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "No Of Days";
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(359, 232);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(240, 30);
            this.txtCharge.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Charge Per Day";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmit.Location = new System.Drawing.Point(449, 386);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(150, 48);
            this.btnsubmit.TabIndex = 52;
            this.btnsubmit.Text = "check";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dtPay
            // 
            this.dtPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPay.Location = new System.Drawing.Point(359, 340);
            this.dtPay.Margin = new System.Windows.Forms.Padding(2);
            this.dtPay.Name = "dtPay";
            this.dtPay.Size = new System.Drawing.Size(240, 23);
            this.dtPay.TabIndex = 51;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(171, 340);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(90, 25);
            this.lblPaid.TabIndex = 50;
            this.lblPaid.Text = "Paid On";
            // 
            // cmbNames
            // 
            this.cmbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(359, 99);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(240, 33);
            this.cmbNames.TabIndex = 48;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(160, 172);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(74, 25);
            this.lblSal.TabIndex = 47;
            this.lblSal.Text = "Salary";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(160, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 25);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Teacher Name";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(359, 167);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(240, 30);
            this.txtAmount.TabIndex = 44;
            // 
            // TeacherSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 523);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dtPay);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAmount);
            this.Name = "TeacherSalary";
            this.Text = "TeacherSalary";
            this.Load += new System.EventHandler(this.TeacherSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DateTimePicker dtPay;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAmount;
    }
}