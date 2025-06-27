namespace student_finances_system
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexist = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnstudentinfo = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btninstallment = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnGenRepo = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRTS = new System.Windows.Forms.Button();
            this.displaypanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnexist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 21);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnexist
            // 
            this.btnexist.BackColor = System.Drawing.Color.Black;
            this.btnexist.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexist.Location = new System.Drawing.Point(951, 0);
            this.btnexist.Margin = new System.Windows.Forms.Padding(2);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(33, 21);
            this.btnexist.TabIndex = 6;
            this.btnexist.Text = "X";
            this.btnexist.UseVisualStyleBackColor = false;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Black;
            this.mainPanel.Controls.Add(this.btnDashboard);
            this.mainPanel.Controls.Add(this.btnstudentinfo);
            this.mainPanel.Controls.Add(this.btnPayment);
            this.mainPanel.Controls.Add(this.btninstallment);
            this.mainPanel.Controls.Add(this.btnExpense);
            this.mainPanel.Controls.Add(this.btnGenRepo);
            this.mainPanel.Controls.Add(this.btnTeacherAdd);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.btnRTS);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 21);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(135, 490);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashboard.Location = new System.Drawing.Point(2, 2);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(133, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Fee Submission";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstudentinfo
            // 
            this.btnstudentinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstudentinfo.BackColor = System.Drawing.Color.Black;
            this.btnstudentinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentinfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnstudentinfo.Location = new System.Drawing.Point(2, 54);
            this.btnstudentinfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnstudentinfo.Name = "btnstudentinfo";
            this.btnstudentinfo.Size = new System.Drawing.Size(133, 56);
            this.btnstudentinfo.TabIndex = 3;
            this.btnstudentinfo.Text = "Student Infomation";
            this.btnstudentinfo.UseVisualStyleBackColor = false;
            this.btnstudentinfo.Click += new System.EventHandler(this.btnstudentinfo_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.BackColor = System.Drawing.Color.Black;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPayment.Location = new System.Drawing.Point(2, 114);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(133, 51);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.button3_Click);
            // 
            // btninstallment
            // 
            this.btninstallment.BackColor = System.Drawing.Color.Black;
            this.btninstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstallment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btninstallment.Location = new System.Drawing.Point(2, 169);
            this.btninstallment.Margin = new System.Windows.Forms.Padding(2);
            this.btninstallment.Name = "btninstallment";
            this.btninstallment.Size = new System.Drawing.Size(133, 56);
            this.btninstallment.TabIndex = 5;
            this.btninstallment.Text = "Installment Detail";
            this.btninstallment.UseVisualStyleBackColor = false;
            this.btninstallment.Click += new System.EventHandler(this.btninstallment_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.Location = new System.Drawing.Point(3, 230);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(127, 52);
            this.btnExpense.TabIndex = 6;
            this.btnExpense.Text = "Add Expenses";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnGenRepo
            // 
            this.btnGenRepo.BackColor = System.Drawing.Color.Black;
            this.btnGenRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenRepo.ForeColor = System.Drawing.Color.White;
            this.btnGenRepo.Location = new System.Drawing.Point(3, 288);
            this.btnGenRepo.Name = "btnGenRepo";
            this.btnGenRepo.Size = new System.Drawing.Size(127, 46);
            this.btnGenRepo.TabIndex = 0;
            this.btnGenRepo.Text = "Manage Expense";
            this.btnGenRepo.UseVisualStyleBackColor = false;
            this.btnGenRepo.Click += new System.EventHandler(this.btnGenRepo_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.BackColor = System.Drawing.Color.Black;
            this.btnTeacherAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherAdd.ForeColor = System.Drawing.Color.White;
            this.btnTeacherAdd.Location = new System.Drawing.Point(3, 340);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(127, 46);
            this.btnTeacherAdd.TabIndex = 3;
            this.btnTeacherAdd.Text = "Teacher Addmission";
            this.btnTeacherAdd.UseVisualStyleBackColor = false;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherSala_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pay Salary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRTS
            // 
            this.btnRTS.BackColor = System.Drawing.Color.Black;
            this.btnRTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTS.ForeColor = System.Drawing.Color.White;
            this.btnRTS.Location = new System.Drawing.Point(3, 439);
            this.btnRTS.Name = "btnRTS";
            this.btnRTS.Size = new System.Drawing.Size(127, 39);
            this.btnRTS.TabIndex = 7;
            this.btnRTS.Text = "Manege RTS";
            this.btnRTS.UseVisualStyleBackColor = false;
            this.btnRTS.Click += new System.EventHandler(this.btnRTS_Click);
            // 
            // displaypanel
            // 
            this.displaypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaypanel.Location = new System.Drawing.Point(135, 21);
            this.displaypanel.Margin = new System.Windows.Forms.Padding(2);
            this.displaypanel.Name = "displaypanel";
            this.displaypanel.Size = new System.Drawing.Size(849, 490);
            this.displaypanel.TabIndex = 2;
            this.displaypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displaypanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.displaypanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnstudentinfo;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btninstallment;
        private System.Windows.Forms.Panel displaypanel;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnGenRepo;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRTS;
    }
}

