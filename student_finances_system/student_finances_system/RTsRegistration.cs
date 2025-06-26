using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

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

            Random rand = new Random();
            string randomNumber = "EXC-" + rand.Next(1000, 10000).ToString();
            bool regDone = Connector.RtsRegistration(randomNumber, name, fatherName, RtsClass);

            if (regDone == true)
            {
                Connector.AutoUpdateFee(randomNumber);

               
                double fee = Connector.RTSClassFee(RtsClass); 
                string slipContent = $"------ FEE SLIP ------\n" +
                                     $"RTS ID     : {randomNumber}\n" +
                                     $"Name       : {name}\n" +
                                     $"Father Name: {fatherName}\n" +
                                     $"Class      : {RtsClass}\n" +
                                     $"Fee        : {fee}\n" +
                                     $"----------------------";

               
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text Files (*.txt)|*.txt";
                saveFile.FileName = $"FeeSlip_{randomNumber}.txt";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, slipContent);
                    MessageBox.Show("Fee slip saved successfully!");
                }

                DialogResult printAsk = MessageBox.Show(" Do you want to print the fee slip?", "Print", MessageBoxButtons.YesNo);
                if (printAsk == DialogResult.Yes)
                {
                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrintPage += (s, ev) =>
                    {
                        ev.Graphics.DrawString(slipContent, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
                    };

                    PrintDialog printDlg = new PrintDialog();
                    printDlg.Document = printDoc;

                    if (printDlg.ShowDialog() == DialogResult.OK)
                    {
                        printDoc.Print();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error in registration!");
            }

            txtName.Text = "";
            TxtFatherName.Text = "";
            cmbClass.SelectedIndex = -1;
        
        }
    }
}
