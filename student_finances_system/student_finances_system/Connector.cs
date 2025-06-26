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
        public static DataSet GenerateExpenseReport(int startingMonth, int endningMonth, int year)
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
            SqlCommand cmd = GetCommand(query, con);
            cmd.Parameters.AddWithValue("@startMonth", startingMonth);
            cmd.Parameters.AddWithValue("@endMonth", endningMonth);
            cmd.Parameters.AddWithValue("@year", year);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "ExpenseTable");

            return ds;
        }
        public static DataSet GenerateStudentReport(int year,int startingMonth, int endningMonth)
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
    WHERE year(PaymentDate)=@year and
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
            cmd.Parameters.AddWithValue("@year", year);

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
        public static void LoadSalary(TextBox t, string selectTeach)
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
        //month hanlding
        public static void AddMonthToComboBox(ComboBox cmb)
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
  
        //teacher salary
        public static void UpdateSalary(string name, int noOfdays, int ChergerPerDay, string date)
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
        //public static void InsertDataAccdemyStudent()
        //{
        //    string query = @"insert into RtsRegistrationAndFee(StudentID,StudentName,FatherName,Class)
        //                    select * from StudentInfoForRTS
        //                    where StudentID not in (select StudentID from RtsRegistrationAndFee);";
        //    try
        //    {
        //        SqlConnection con = CreateConnection();
        //        SqlCommand cmd = GetCommand(query, con);
        //        int effectedRow = cmd.ExecuteNonQuery();
        //        if (effectedRow > 0)
        //        {
        //            MessageBox.Show("Done");
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Not Added");
        //    }

        //}
        //new std rts Resiger
        public static bool RtsRegistration(string RTSID, string name, string fatherName, string rtsClass)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1000, 10000);
            string studentID = randomNumber.ToString();

            string query = @"insert into RtsRegistrationAndFee(RTSID,StudentID,StudentName,FatherName,Class)
                    values(@RTSID,@studentID,@StudentName,@FatherName,@Class)";

            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);
                cmd.Parameters.AddWithValue("@RTSID", RTSID);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@FatherName", fatherName);
                cmd.Parameters.AddWithValue("@Class", rtsClass);
                int effectedRow = cmd.ExecuteNonQuery();
                if (effectedRow > 0)
                {
                    MessageBox.Show("Register Successfullu!!!");

                }
                return true;





            }
            catch
            {
                MessageBox.Show("!! Failed Registertion");
                return false;

            }

        }
        public static void AutoUpdateFee(string RTSID)
        {
            string query = @"
        UPDATE RtsRegistrationAndFee
        SET [RTS FEE] = (
            SELECT RTSFEE 
            FROM SetRTSFee 
            WHERE SetRTSFee.Class = RtsRegistrationAndFee.Class
        )
        WHERE RTSID = @RTSID AND payment =0";

            SqlConnection con = CreateConnection();
            SqlCommand cmd = GetCommand(query, con);
            cmd.Parameters.AddWithValue("@RTSID", RTSID);

            int effectedRow = cmd.ExecuteNonQuery();
            if (effectedRow > 0)
            {
                MessageBox.Show(" Auto Fee Updated Successfully.");
            }
            else
            {
                MessageBox.Show(" Could Not Set Auto Fee. Either payment is already made or class mismatch.");
            }
        }


        //seting rts Fees
        public static void SetRTSFee(int RTSFEE, string RTSClass)
        {
            string query = @"update SetRTSFee
                set RTSFEE=@Fee
                    where class=@RTSClass";
            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);
                cmd.Parameters.AddWithValue("@Fee", RTSFEE);
                cmd.Parameters.AddWithValue("@RTSClass", RTSClass);
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0)
                {
                    MessageBox.Show($"Update RTS FEE {RTSClass}");
                }

            }
            catch
            {
                MessageBox.Show($"Not Updated RTS FEE OF {RTSClass}");
            }
        }
        //Paying Fee of Rts in with installment
        public static void PayRTSFee(string RTSID, int installMentAmount, int noOfInstallments, string date,double percentage)
        {
            string query = @"UPDATE RtsRegistrationAndFee
                        SET 
                        payMentDate=@date,
                        payment = payment + @instamentAmount,
                        [RTS FEE]=[RTS FEE]-([RTS FEE]*@Pectage),
                        NoInstallMents = @Installment - 1,
                        isPaid=ispaid+1
                        WHERE RTSID = @RTSID";
            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@instamentAmount", installMentAmount);
                cmd.Parameters.AddWithValue("@Pectage", percentage);
                cmd.Parameters.AddWithValue("@Installment", noOfInstallments);
                cmd.Parameters.AddWithValue("@RTSID", RTSID);
                int effectedRow = cmd.ExecuteNonQuery();
                if (effectedRow > 0)
                {
                    MessageBox.Show($"{noOfInstallments} Install is Paid Remaining {noOfInstallments - 1}");
                }
            }
            catch
            {
                MessageBox.Show("Not Paid ");
            }

        }
        public static double RTSClassFee(string rtsClass)
        {
            double ClassFee;
            string query = @"select RTSFEE from SetRTSFee
                            where class=@rtsClass";
            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);
                cmd.Parameters.AddWithValue("@rtsClass", rtsClass);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ClassFee = Convert.ToDouble(reader["RTSFEE"]);
                    return ClassFee;
                }
                else{
                    MessageBox.Show($"!!! Add RTS FEE OF Claas{rtsClass}");
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Error");
                return 0;
            }
            
        }
        public static DataSet GetDataOfRTS(string RTSID)
        {
            string str = @"Data Source=HABIBSYSTEM\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
            string query = @"select * from RtsRegistrationAndFee where RTSID like @RTSID";
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = GetCommand(query, con);
                cmd.Parameters.AddWithValue("@RTSID", "%" + RTSID + "%");
               
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "RTSTABLE");
                return ds;
            }
            catch
            {
                MessageBox.Show("Conneect DataBase");
                return ds;
            }
           
        }
        public static DataSet CreatRTSReport(int year,int startingMonth,int endingMonth)
        {

            string query = @"
        SELECT 
            RTSID,
            StudentID,
            StudentName,
            FatherName,
            Class,
            PayMentDate,
            NoInstallMents,
            [RTS FEE],
            Payment,
            ISPAID
        FROM RtsRegistrationAndFee
        WHERE 
            MONTH(PayMentDate) BETWEEN @startMonth AND @endMonth
            AND YEAR(PayMentDate) = @Year
        ORDER BY 
            CASE 
                WHEN Class = '9th' THEN 1
                WHEN Class = '10th' THEN 2
                WHEN Class = '11th' THEN 3
                WHEN Class = '12th' THEN 4
                ELSE 5
            END;";
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = GetCommand(query, con);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@startMonth",startingMonth);
                cmd.Parameters.AddWithValue("@endMonth", endingMonth);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "RTSReportTable");
                return ds;
            }
            catch
            {
                MessageBox.Show("Error");
                return ds;
            }

        }

    }
   
}
