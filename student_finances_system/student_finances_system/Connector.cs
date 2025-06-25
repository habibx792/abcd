using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace student_finances_system
{
    class Connector
    {
        public static SqlConnection CreateConnection()
        {
            string str = @"Data Source=HABIBSYSTEM\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                MessageBox.Show("Connected");
                return con;
            }
            catch
            {
                MessageBox.Show("Conncectivity errror");
            }
            return con;
        }
        public static SqlCommand GetCommand(string query, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd;
        }
        public static void AddExpenses(string expenseName, int amount, string date, string month)
        {
            string query = @"insert into Expenses(ExpenceType,Amount,Date,Month)
                                    values(@bill,@amount,@date,@month)";
            SqlConnection con = CreateConnection();
            SqlCommand cmd = GetCommand(query, con);
            //
            try
            {
               
                cmd.Parameters.AddWithValue("@bill", expenseName);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@month", month);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("Not addes");
                }
            }
            catch
            {
                MessageBox.Show("Error Message");
            }

        }
        public static DataSet GenerateExpenseReport(int startingMonth,int endningMonth,int year)
        {
            string query = @"SELECT *
                    FROM Expenses
                    WHERE 
                     YEAR(Date) = 2025 AND 
                 (
            CASE Month
            WHEN 'January' THEN 1
            WHEN 'February' THEN 2
            WHEN 'March' THEN 3
            WHEN 'April' THEN 4
            WHEN 'May' THEN 5
            WHEN 'June' THEN 6
            WHEN 'July' THEN 7
            WHEN 'August' THEN 8
            WHEN 'September' THEN 9
            WHEN 'October' THEN 10
            WHEN 'November' THEN 11
            WHEN 'December' THEN 12
            ELSE 0  -- fallback for unmatched values
             END
            ) BETWEEN @startMonth AND @endMonth";


            SqlConnection con = CreateConnection();
            SqlCommand cmd = GetCommand(query,con);
            cmd.Parameters.AddWithValue("@startMonth",startingMonth);
            cmd.Parameters.AddWithValue("@endMonth",endningMonth);
            cmd.Parameters.AddWithValue("@year",year);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "ExpenseTable");

            return ds;
        }
        public static DataSet GenerateStudentReport(int startingMonth, int endningMonth)
        {
            SqlConnection con = CreateConnection();
            string query = @"SELECT *
                    FROM TransactionHistory
                    WHERE 
                    
                 (
            CASE MonthName
            WHEN 'January' THEN 1
            WHEN 'February' THEN 2
            WHEN 'March' THEN 3
            WHEN 'April' THEN 4
            WHEN 'May' THEN 5
            WHEN 'June' THEN 6
            WHEN 'July' THEN 7
            WHEN 'August' THEN 8
            WHEN 'September' THEN 9
            WHEN 'October' THEN 10
            WHEN 'November' THEN 11
            WHEN 'December' THEN 12
            ELSE 0  -- fallback for unmatched values
             END
            ) BETWEEN @startMonth AND @endMonth";
          
            SqlCommand cmd = GetCommand(query, con);
            cmd.Parameters.AddWithValue("@startMonth", startingMonth);
            cmd.Parameters.AddWithValue("@endMonth", endningMonth);
            
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "StudentReport");
            return ds;
        }
        public static void TeacherAdmission(string teacherName, string qualification, int salary, string dateOfJoinig)
        {
            string query = @"insert into TeacherRecord(TeacherName,Qualification,DateOfJoining,Salary)
                             values(@name,@qualification,@dateJoining,@salary)";

            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);
                cmd.Parameters.AddWithValue("@name", teacherName);
                cmd.Parameters.AddWithValue("@qualification", qualification);
                cmd.Parameters.AddWithValue("@dateJoining", DateTime.Parse(dateOfJoinig));
                cmd.Parameters.AddWithValue("@salary", salary);
                int effectedRows = cmd.ExecuteNonQuery();
                if (effectedRows > 0)
                {
                    MessageBox.Show("Values Are adeed");

                }
                
            }
            catch
            {
                MessageBox.Show("Erro");
            }
            


        }
    }
}
