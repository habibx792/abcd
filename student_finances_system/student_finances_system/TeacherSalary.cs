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
    public partial class TeacherSalary : Form
    {
        public TeacherSalary()
        {
            InitializeComponent();
        }

        private void TeacherSalary_Load(object sender, EventArgs e)
        {
            
            Connector.LoadTeacherName(cmbNames);
            btnsubmit.Text = "Check";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string teacherName = cmbNames.SelectedItem.ToString();
           
            string paidDate= dtPay.Value.ToString("yyyy-MM-dd");
            
            if(btnsubmit.Text== "Check")
            {
                Connector.LoadSalary(txtAmount, teacherName);
                btnsubmit.Text = "Pay";

            }
            else if (btnsubmit.Text == "Pay")
            {
                int chargePerDay = int.Parse(txtCharge.Text);
                int noOfDays = int.Parse(txtdays.Text);
                Connector.UpdateSalary(teacherName, noOfDays, chargePerDay, paidDate);
            }
           
        }
    }
}
