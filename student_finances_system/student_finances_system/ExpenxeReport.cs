using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using System.Globalization;
namespace student_finances_system
{
    public partial class ExpenxeReport : Form
    {
        public ExpenxeReport()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DatagridStd.Visible = false;
            ExpenseDataGrid.Visible = true;

            string startMonthName = ((KeyValuePair<int, string>)cmbStartMonth.SelectedItem).Value;
            string endMonthName = ((KeyValuePair<int, string>)cmbEndMonth.SelectedItem).Value;

            int startDate = DateTime.ParseExact(startMonthName, "MMMM", CultureInfo.InvariantCulture).Month;
            int endDate = DateTime.ParseExact(endMonthName, "MMMM", CultureInfo.InvariantCulture).Month;


            int year = int.Parse(cmbYear.SelectedItem.ToString());   
            DataSet ds = Connector.GenerateExpenseReport(startDate, endDate, year);
            ExpenseDataGrid.AutoGenerateColumns = true;
            ExpenseDataGrid.Columns.Clear();
            ExpenseDataGrid.DataSource = ds.Tables["ExpenseTable"];
            ExpenseDataGrid.Columns["ExpnseID"].Width = 175;
            ExpenseDataGrid.Columns["ExpenceType"].Width = 175;
            ExpenseDataGrid.Columns["Amount"].Width = 169;
            ExpenseDataGrid.Columns["Date"].Width = 175;
            ExpenseDataGrid.Columns["Month"].Width = 145;

            //int year = DateTime.Now;
            
            Label lab = new Label();
          

        }

        private void ExpenxeReport_Load(object sender, EventArgs e)
        {
            ExpenseDataGrid.Columns[0].Width = 100;
            ExpenseDataGrid.Columns[1].Width = 100;
            ExpenseDataGrid.Columns[2].Width = 100;
            ExpenseDataGrid.Columns[3].Width = 100;
            ExpenseDataGrid.Columns[4].Width = 100;

            Connector.AddMonthToComboBox(cmbStartMonth);
            Connector.AddMonthToComboBox(cmbEndMonth);

            Connector.AddMonthToComboBox(cmbstdStartmonth);
            Connector.AddMonthToComboBox(cmbstdEndmonth);
           

            Connector.AddMonthToComboBox(cmbLostStart);
            Connector.AddMonthToComboBox(cmbLostEnd);

            lblYearNow.Text = "";
            lblYearNow.Text = DateTime.Now.Year.ToString();
            int year = int.Parse(DateTime.Now.Year.ToString());
            int backYear = year - 5;
            int forwardYear = year + 5;
            for(int i= backYear; i <= forwardYear; i++)
            {
                cmbYear.Items.Add(i);
                cmbstdYear.Items.Add(i);
                cmbLostYear.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExpenseDataGrid.Rows.Count > 0)
            {
                // You can also replace this with a hardcoded path instead of SaveFileDialog
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = "ExpenseReport.xlsx", // default name
                    InitialDirectory = @"C:\Reports\" // Change to your desired folder
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = new DataTable();

                            // Add columns
                            foreach (DataGridViewColumn col in ExpenseDataGrid.Columns)
                                dt.Columns.Add(col.HeaderText);

                            // Add rows
                            foreach (DataGridViewRow row in ExpenseDataGrid.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    DataRow newRow = dt.NewRow();
                                    for (int i = 0; i < ExpenseDataGrid.Columns.Count; i++)
                                    {
                                        newRow[i] = row.Cells[i].Value?.ToString();
                                    }
                                    dt.Rows.Add(newRow);
                                }
                            }

                            // Add DataTable to worksheet
                            var ws = workbook.Worksheets.Add(dt, "ExpenseReport");

                            // 🔢 Calculate total for "Amount" (or "Salary" if applicable)
                            double totalAmount = 0;
                            if (ExpenseDataGrid.Columns.Contains("Amount"))
                            {
                                foreach (DataGridViewRow row in ExpenseDataGrid.Rows)
                                {
                                    if (!row.IsNewRow && double.TryParse(row.Cells["Amount"].Value?.ToString(), out double amount))
                                    {
                                        totalAmount += amount;
                                    }
                                }

                                // 🧮 Write total in next row under Amount column
                                int totalRow = dt.Rows.Count + 2; // +1 for header, +1 for index offset
                                int amountColIndex = ExpenseDataGrid.Columns["Amount"].Index + 1;

                                ws.Cell(totalRow, amountColIndex - 1).Value = "Total:";
                                ws.Cell(totalRow, amountColIndex).Value = totalAmount;
                            }

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Excel report saved successfully!", "Success");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data to export!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblExpenseReport_Click(object sender, EventArgs e)
        {

        }

        private void btnStdReport_Click(object sender, EventArgs e)
        {
            ExpenseDataGrid.Visible = false;
            DatagridStd.Visible = true;
            string startMonthName = ((KeyValuePair<int, string>)cmbstdStartmonth.SelectedItem).Value;
            string endMonthName = ((KeyValuePair<int, string>)cmbstdEndmonth.SelectedItem).Value;
            string input = cmbYear.Text;
            string yearInput = cmbYear.Text;

            //int year;
            //if (int.TryParse(yearInput, out year))
            //{
            //    MessageBox.Show("❌ Invalid year format. Please type a number like 2025.");
            //    return;
            //}
            int startDate = DateTime.ParseExact(startMonthName, "MMMM", CultureInfo.InvariantCulture).Month;
            int endDate = DateTime.ParseExact(endMonthName, "MMMM", CultureInfo.InvariantCulture).Month;

            DataSet ds = Connector.GenerateStudentReport(startDate, endDate);
            DatagridStd.DataSource = ds.Tables["StudentReport"];




           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStdExel_Click(object sender, EventArgs e)
        {
            if (DatagridStd.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save Student Report",
                    FileName = "StudentReport.xlsx"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = new DataTable("StudentReport");

                            // Add columns from DataGridView
                            foreach (DataGridViewColumn col in DatagridStd.Columns)
                            {
                                dt.Columns.Add(col.HeaderText);
                            }

                            // Add rows from DataGridView
                            foreach (DataGridViewRow row in DatagridStd.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    DataRow newRow = dt.NewRow();
                                    for (int i = 0; i < DatagridStd.Columns.Count; i++)
                                    {
                                        newRow[i] = row.Cells[i].Value?.ToString() ?? "";
                                    }
                                    dt.Rows.Add(newRow);
                                }
                            }

                            var ws = workbook.Worksheets.Add(dt);

                            // 🎨 Format header row
                            var headerRange = ws.Range(1, 1, 1, dt.Columns.Count);
                            headerRange.Style.Fill.BackgroundColor = XLColor.LightSteelBlue;
                            headerRange.Style.Font.FontColor = XLColor.White;
                            headerRange.Style.Font.Bold = true;
                            headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            headerRange.Style.Font.FontName = "Calibri";

                            // 📏 Set custom column widths
                            for (int i = 1; i <= dt.Columns.Count; i++)
                            {
                                ws.Column(i).Width = 20; // or set different widths if needed
                            }

                            // 🔢 Calculate total of AmountPaid where IsPaid == 1
                            double totalAmountPaid = 0;
                            foreach (DataGridViewRow row in DatagridStd.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    bool isPaid = row.Cells["IsPaid"].Value?.ToString() == "True" || row.Cells["IsPaid"].Value?.ToString() == "1";
                                    if (isPaid && double.TryParse(row.Cells["AmountPaid"].Value?.ToString(), out double amt))
                                    {
                                        totalAmountPaid += amt;
                                    }
                                }
                            }

                            // 🧮 Add Total Row
                            int totalRowIndex = dt.Rows.Count + 2;
                            int amountColIndex = DatagridStd.Columns["AmountPaid"].Index + 1;
                            int labelColIndex = amountColIndex - 1;

                            ws.Cell(totalRowIndex, labelColIndex).Value = "Total Paid:";
                            ws.Cell(totalRowIndex, amountColIndex).Value = totalAmountPaid;

                            // 🎨 Style total row in red and bold
                            var totalRange = ws.Range(totalRowIndex, labelColIndex, totalRowIndex, amountColIndex);
                            totalRange.Style.Font.FontColor = XLColor.Red;
                            totalRange.Style.Font.Bold = true;

                            // ✅ Save the Excel file
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("✅ Excel file saved with colored headers and total!", "Success");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("⚠️ No student data found to export!", "Export Error");
            }
        }



    }
}
