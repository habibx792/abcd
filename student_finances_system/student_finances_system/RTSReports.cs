using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ClosedXML.Excel;
using System.IO;
using System.Diagnostics;
namespace student_finances_system
{
    public partial class RTSReports : UserControl
    {
        public RTSReports()
        {
            InitializeComponent();
        }

        private void RTSReports_Load(object sender, EventArgs e)
        {
            Connector.AddMonthToComboBox(cmbStartMonth);
            Connector.AddMonthToComboBox(cmbEndMonth);
            int year = DateTime.Now.Year;
            int backYear = year - 5;
            int forwardYear = year + 5;
            for (int i = backYear; i <= forwardYear; i++)
            {
                cmbYear.Items.Add(i);
               
            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string startMonthName = ((KeyValuePair<int, string>)cmbStartMonth.SelectedItem).Value;
            string endMonthName = ((KeyValuePair<int, string>)cmbEndMonth.SelectedItem).Value;

           
            int startMonth = DateTime.ParseExact(startMonthName, "MMMM", CultureInfo.InvariantCulture).Month;
            int endMonth = DateTime.ParseExact(endMonthName, "MMMM", CultureInfo.InvariantCulture).Month;
            int year = int.Parse(cmbYear.Text);

           
            label2.Text = startMonth.ToString();
            label3.Text = endMonth.ToString();

          

            DataSet ds = Connector.CreatRTSReport(year,startMonth,endMonth) ;
            ReportDataGrid.DataSource = ds.Tables["RTSReportTable"];
        }

        private void cmbEndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnexelreport_Click(object sender, EventArgs e)
        {
            if (ReportDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = "RTS_Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx",
                InitialDirectory = @"C:\Reports\"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    DataTable dt = new DataTable();

                    // Add columns
                    foreach (DataGridViewColumn col in ReportDataGrid.Columns)
                        dt.Columns.Add(col.HeaderText);

                    // Add rows
                    foreach (DataGridViewRow row in ReportDataGrid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            DataRow newRow = dt.NewRow();
                            for (int i = 0; i < ReportDataGrid.Columns.Count; i++)
                            {
                                newRow[i] = row.Cells[i].Value?.ToString();
                            }
                            dt.Rows.Add(newRow);
                        }
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var ws = workbook.Worksheets.Add(dt, "RTS Report");

                        // Header style
                        var headerRange = ws.Range(1, 1, 1, dt.Columns.Count);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Font.FontColor = XLColor.White;
                        headerRange.Style.Font.FontSize = 13;
                        headerRange.Style.Fill.BackgroundColor = XLColor.Teal;
                        headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        headerRange.Style.Border.OutsideBorderColor = XLColor.Black;

                        double totalPayment = 0;
                        int rowCount = dt.Rows.Count;
                        int paymentColIndex = ReportDataGrid.Columns["Payment"].Index + 1;
                        int feeColIndex = ReportDataGrid.Columns["RTS FEE"].Index + 1;

                        for (int i = 0; i < rowCount; i++)
                        {
                            double.TryParse(dt.Rows[i]["Payment"].ToString(), out double payment);
                            double.TryParse(dt.Rows[i]["RTS FEE"].ToString(), out double fee);

                            if (payment == fee)
                            {
                                ws.Cell(i + 2, paymentColIndex).Style.Fill.BackgroundColor = XLColor.LightGreen;
                                ws.Cell(i + 2, feeColIndex).Style.Fill.BackgroundColor = XLColor.LightGreen;
                            }

                            totalPayment += payment;

                            // Add border to all cells
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                var cell = ws.Cell(i + 2, j + 1);
                                cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                cell.Style.Border.OutsideBorderColor = XLColor.LightGray;
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }
                        }

                        // Total row
                        int totalRow = rowCount + 2;
                        ws.Cell(totalRow, paymentColIndex - 1).Value = "Total";
                        ws.Cell(totalRow, paymentColIndex - 1).Style.Font.Bold = true;
                        ws.Cell(totalRow, paymentColIndex - 1).Style.Fill.BackgroundColor = XLColor.Yellow;

                        ws.Cell(totalRow, paymentColIndex).Value = totalPayment;
                        ws.Cell(totalRow, paymentColIndex).Style.Font.Bold = true;
                        ws.Cell(totalRow, paymentColIndex).Style.Fill.BackgroundColor = XLColor.Yellow;

                        ws.Columns().AdjustToContents();
                        foreach (var col in ws.ColumnsUsed())
                        {
                            col.Width += 5;
                        }

                        workbook.SaveAs(filePath);
                    }

                    // Ask to print
                    DialogResult result = MessageBox.Show("Report saved successfully!\nDo you want to print the report?", "Print Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Use default app (Excel) to open and print
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = filePath,
                                Verb = "Print",
                                CreateNoWindow = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            };
                            Process.Start(psi);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Printing failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }


}

