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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.bntSerach = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetRtsFee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Location = new System.Drawing.Point(1, 54);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(722, 400);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegister_Paint);
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
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(146, 3);
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
            this.bntSerach.Location = new System.Drawing.Point(284, 3);
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
            this.button5.Location = new System.Drawing.Point(440, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 42);
            this.button5.TabIndex = 3;
            this.button5.Text = "TRS Report";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnSetRtsFee);
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
            // btnSetRtsFee
            // 
            this.btnSetRtsFee.Location = new System.Drawing.Point(574, 3);
            this.btnSetRtsFee.Name = "btnSetRtsFee";
            this.btnSetRtsFee.Size = new System.Drawing.Size(122, 42);
            this.btnSetRtsFee.TabIndex = 4;
            this.btnSetRtsFee.Text = "Set RTS FEE";
            this.btnSetRtsFee.UseVisualStyleBackColor = true;
            this.btnSetRtsFee.Click += new System.EventHandler(this.btnSetRtsFee_Click);
            // 
            // MangeRTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "MangeRTS";
            this.Text = "MangeRTS";
            this.Load += new System.EventHandler(this.MangeRTS_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button bntSerach;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetRtsFee;
    }
}