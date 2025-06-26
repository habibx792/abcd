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
            string query = @"
    SELECT 
        TransactionID, 
        StudentInfo.StudentID, 
        FullName, 
        FatherName, 
        Class,       
        TransactionHistory.AmountPaid,
        IsPaid
    FROM TransactionHistory
    INNER JOIN StudentInfo 
        ON TransactionHistory.StudentID = StudentInfo.StudentID
    WHERE 
        TransactionHistory.IsPaid = 1
        AND (
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
                ELSE 0
            END
        ) BETWEEN @startMonth AND @endMonth order by Class;";

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
                cmd.Parameters.AddWithValue("@name",teacherName);
                cmd.Parameters.AddWithValue("@qualification", qualification);
                cmd.Parameters.AddWithValue("@dateJoining", dateOfJoinig);
                cmd.Parameters.AddWithValue("@salary", salary);
                 cmd.ExecuteNonQuery();
               
                
                    MessageBox.Show("Values Are adeed");

                
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            


        }
        public static void LoadTeacherName(ComboBox cmb)
        {
            string query = @"select TeacherName from TeacherRecord";
            SqlConnection con = CreateConnection();
            SqlCommand cmd = GetCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb.Items.Add(reader["TeacherName"].ToString());
            }
            MessageBox.Show("Done");
        }
        public static void LoadSalary(TextBox t,string selectTeach)
        {
            string query = @"select salary from TeacherRecord where teacherName=@name";
            SqlConnection con = CreateConnection();
            SqlCommand cmd = GetCommand(query, con);
            cmd.Parameters.AddWithValue("@name", selectTeach);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                t.Text = reader["salary"].ToString();
            }


        }
        public static  void  AddMonthToComboBox(ComboBox cmb)
        {
            Dictionary<int, string> months = new Dictionary<int, string>
{
                     {1, "January"},
                     {2, "February"},
                     {3, "March"},
                     {4, "April"},
                     {5, "May"},
                     {6, "June"},
                     {7, "July"},
                     {8, "August"},
                     {9, "September"},
                      {10, "October"},
                      {11, "November"},
                      {12, "December"}
};
            cmb.DataSource = new BindingSource(months, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";
            cmb.DataSource = new BindingSource(months, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";
        }
        public static void UpdateSalary(string name,int noOfdays,int ChergerPerDay,string date)
        {
            string query = @"UPDATE TeacherRecord
                            SET NetPaid = (SELECT Salary - (@noOfdays * @ChergerPerDay) FROM TeacherRecord WHERE teacherName = 'ali'),  IsPaid=1,PaidDate=@Date
                            WHERE teacherName = @name";
            SqlConnection con = CreateConnection();
            SqlCommand cmd = GetCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@noOfdays", noOfdays);
            cmd.Parameters.AddWithValue("@ChergerPerDay", ChergerPerDay);
            cmd.Parameters.AddWithValue("@date", date);

            int effectedRow = cmd.ExecuteNonQuery();
            if (effectedRow > 0)
            {
                MessageBox.Show("Paid");
            }
        }
        // maganenig rts
        //inserting alread std from accedmy data
        public static void InsertDataAccdemyStudent()
        {
            string query = @"insert into RtsRegistrationAndFee(StudentID,StudentName,FatherName,Class)
                            select * from StudentInfoForRTS
                            where StudentID not in (select StudentID from RtsRegistrationAndFee);";
            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);
                int effectedRow = cmd.ExecuteNonQuery();
                if (effectedRow > 0)
                {
                    MessageBox.Show("Done");
                }
            }
            catch
            {
                MessageBox.Show("Not Added");
            }
           
        }
        //new std rts Resiger
        public static void RtsRegistration(string name,string fatherName,string rtsClass)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1000, 10000); 
            string studentID = randomNumber.ToString();

            string query = @"insert into RtsRegistrationAndFee(StudentID,StudentName,FatherName,Class)
                    values(@studentID,@StudentName,@FatherName,@Class)";
           
            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@FatherName", fatherName);
                 cmd.Parameters.AddWithValue("@Class", rtsClass);
                int effectedRow = cmd.ExecuteNonQuery();
                if (effectedRow > 0)
                {
                    MessageBox.Show("Register Successfullu!!!");
                }


            }
            catch
            {
                MessageBox.Show("!! Failed Registertion");
            }
        }
    }
}
