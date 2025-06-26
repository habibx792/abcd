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
          //  Connector.InsertDataAccdemyStudent();
            MainPanel.Height = 710;
            MainPanel.Width = 440;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

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
            MainPanel.Controls.Clear();
            RTSPayeMent rtsReg = new RTSPayeMent();
            rtsReg.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(rtsReg);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntSerach_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            SearchRTS SeerhcEngine = new SearchRTS();
            SeerhcEngine.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(SeerhcEngine);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            RTSReports Report = new RTSReports();
            Report.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Report);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            MainPanel.Controls.Clear();
            RTSRegistertion rtsReg = new RTSRegistertion();
            rtsReg.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(rtsReg);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSetRtsFee_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            SetRTSFEE SetFee = new SetRTSFEE();
            SetFee.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(SetFee);

        }



       
    }
}
