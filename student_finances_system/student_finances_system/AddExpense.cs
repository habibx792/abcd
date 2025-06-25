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
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string expenseName = txtexpensename.Text;
                int amount = int.Parse(txtamount.Text);
                string date = dtpdate.Value.ToString("yyyy-MM-dd");
                string month = cmbmonth.SelectedItem.ToString();
                Connector.AddExpenses(expenseName, amount, date, month);
                label1.Text = dtpdate.Value.ToString("yyyy-MM-dd");

            }
            catch
            {
                MessageBox.Show("Erro");
            }
         
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void dtpdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddExpense_Load(object sender, EventArgs e)
        {

        }
    }
}
