using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_finances_system
{
    class Teacher
    {
        private string  teacherName;
        private string qualification;
        private int salary;
        private string dateOfJoinig;
        public Teacher(string teacherName,string qualification,int salary,string dateOfJoinig)
        {
            this.teacherName = teacherName;
            this.qualification = qualification;
            this.salary = salary;
            this.dateOfJoinig = dateOfJoinig;

        }
        public string TeacherName
        {
            get {return teacherName; }
        }
        public string Qualification
        {
            get { return qualification; }
        } 
        public int Salary
        {
            get { return salary; }
        }
        public string DateOfJoining
        {
            get { return dateOfJoinig; }
        }
    }
}
