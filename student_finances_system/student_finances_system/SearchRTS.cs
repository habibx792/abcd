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

namespace student_finances_system
{
    public partial class SearchRTS : UserControl
    {
        public SearchRTS()
        {
            InitializeComponent();
        }

        private void SearchRTS_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds= Connector.GetDataOfRTS(txtSearch.Text);
            gridSerach.DataSource = ds.Tables["RTSTABLE"];

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gridSerach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            
            DataGridViewRow row = gridSerach.SelectedRows[0];

            
            string report = "-------- Student Report --------\n";
            foreach (DataGridViewCell cell in row.Cells)
            {
                report += $"{gridSerach.Columns[cell.ColumnIndex].HeaderText}: {cell.Value}\n";
            }
            report += "--------------------------------\n";

            
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt";
            saveDialog.FileName = "Student_Report.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, report);
                MessageBox.Show(" Report saved successfully!");
            }
        }
    }
    
}
