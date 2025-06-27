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
    public partial class SetRTSFEE : UserControl
    {
        public SetRTSFEE()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string ClassName = cmbClass.SelectedItem.ToString();
            int amount = int.Parse(txtFee.Text);
            Connector.SetRTSFee(amount, ClassName);
            txtFee.Text = "";
            cmbClass.SelectedIndex = -1;
        }
    }
}
