using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_finances_system
{
    public partial class MangeRTS : Form
    {
        public MangeRTS()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MangeRTS_Load(object sender, EventArgs e)
        {
            Connector.InsertDataAccdemyStudent();
            PanelRegister.Height = 710;
            PanelRegister.Width = 440;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string fatherName = TxtFatherName.Text;
            string RtsClass = cmbClass.SelectedItem.ToString();
            Connector.RtsRegistration(name,fatherName, RtsClass);
            txtName.Text = "";
            TxtFatherName.Text = "";

          
            cmbClass.SelectedIndex = -1;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelPayFee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PanelRegister.Visible = false;

            // Add the UserControl to the panel


            RTSPayeMent paymentControl = new RTSPayeMent();
            paymentControl.Dock = DockStyle.Fill;
            PanelRegister.Controls.Add(paymentControl);




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntSerach_Click(object sender, EventArgs e)
        {

        }
    }
}
