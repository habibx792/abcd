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
    public partial class RTSPayeMent : UserControl
    {
      
        public RTSPayeMent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double RTSClassFEE=0;
            string RTSID =TxtRTSID.Text;
            //Connector.AutoUpdateFee(RTSID);
            string rtsClass = cmbClass.SelectedItem.ToString();
            int InstallMentAmount = int.Parse(txtImstallmentAMount.Text);

            int numofInstallments = int.Parse(cmbnoInstallments.SelectedItem.ToString());
            if (numofInstallments == 0)
            {
                numofInstallments += 1;
            }
            double percentage = 0;
            string date=dtPaymentData.Value.ToString("yyyy-MM-dd");
            if (btnPay.Text == "Pay")
            {
                RTSClassFEE = Connector.RTSClassFee(rtsClass);
              double concenssion =double.Parse(txtConcession.Text);
                percentage = concenssion / RTSClassFEE;
                lblPercentage.Text = percentage.ToString();
                lblamount.Text = RTSClassFEE.ToString();
                txtPercnetage.Text = percentage.ToString();
                btnPay.Text = "Are you Sure";
                btnPay.Width = 200;
                btnPay.Height = 55;
                
                
            }
            else if(btnPay.Text == "Are you Sure")
            {
                Connector.PayRTSFee(RTSID, InstallMentAmount, numofInstallments, date, percentage);
                btnPay.Text = "Pay";
            }

            
        }

        private void RTSPayeMent_Load(object sender, EventArgs e)
        {
        }
    }
}
