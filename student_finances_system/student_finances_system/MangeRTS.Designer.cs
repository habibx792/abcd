namespace student_finances_system
{
    partial class MangeRTS
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
            this.PanelRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.bntSerach = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregisterNew = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.TxtFatherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRegister.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegister
            // 
            this.PanelRegister.Controls.Add(this.label1);
            this.PanelRegister.Controls.Add(this.label6);
            this.PanelRegister.Controls.Add(this.cmbClass);
            this.PanelRegister.Controls.Add(this.label4);
            this.PanelRegister.Controls.Add(this.label3);
            this.PanelRegister.Controls.Add(this.TxtFatherName);
            this.PanelRegister.Controls.Add(this.txtName);
            this.PanelRegister.Controls.Add(this.btnregisterNew);
            this.PanelRegister.Location = new System.Drawing.Point(1, 54);
            this.PanelRegister.Name = "PanelRegister";
            this.PanelRegister.Size = new System.Drawing.Size(710, 77);
            this.PanelRegister.TabIndex = 0;
            this.PanelRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegister_Paint);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(18, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 42);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Student Registration";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(188, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(117, 42);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // bntSerach
            // 
            this.bntSerach.BackColor = System.Drawing.Color.Black;
            this.bntSerach.ForeColor = System.Drawing.Color.White;
            this.bntSerach.Location = new System.Drawing.Point(339, 3);
            this.bntSerach.Name = "bntSerach";
            this.bntSerach.Size = new System.Drawing.Size(127, 42);
            this.bntSerach.TabIndex = 2;
            this.bntSerach.Text = "Search";
            this.bntSerach.UseVisualStyleBackColor = false;
            this.bntSerach.Click += new System.EventHandler(this.bntSerach_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(536, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 42);
            this.button5.TabIndex = 3;
            this.button5.Text = "TRS Report";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.bntSerach);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 48);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnregisterNew
            // 
            this.btnregisterNew.Location = new System.Drawing.Point(376, 260);
            this.btnregisterNew.Name = "btnregisterNew";
            this.btnregisterNew.Size = new System.Drawing.Size(101, 40);
            this.btnregisterNew.TabIndex = 1;
            this.btnregisterNew.Text = "Register";
            this.btnregisterNew.UseVisualStyleBackColor = true;
            this.btnregisterNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 3;
            // 
            // TxtFatherName
            // 
            this.TxtFatherName.Location = new System.Drawing.Point(270, 165);
            this.TxtFatherName.Name = "TxtFatherName";
            this.TxtFatherName.Size = new System.Drawing.Size(207, 20);
            this.TxtFatherName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Father Name";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "9th",
            "10th",
            "11th",
            "12th"});
            this.cmbClass.Location = new System.Drawing.Point(270, 199);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(207, 21);
            this.cmbClass.TabIndex = 11;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student Name";
            // 
            // MangeRTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelRegister);
            this.Name = "MangeRTS";
            this.Text = "MangeRTS";
            this.Load += new System.EventHandler(this.MangeRTS_Load);
            this.PanelRegister.ResumeLayout(false);
            this.PanelRegister.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button bntSerach;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFatherName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnregisterNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}