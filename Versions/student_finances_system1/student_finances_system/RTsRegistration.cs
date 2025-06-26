using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_finances_system
{
    public partial class RTSRegistertion : UserControl
    {
        public RTSRegistertion()
        {
            InitializeComponent();
        }

        private void btnregisterNew_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string fatherName = TxtFatherName.Text;
            string RtsClass = cmbClass.SelectedItem.ToString();
            Connector.RtsRegistration(name, fatherName, RtsClass);
            txtName.Text = "";
            TxtFatherName.Text = "";


            cmbClass.SelectedIndex = -1;
        }
    }
}
