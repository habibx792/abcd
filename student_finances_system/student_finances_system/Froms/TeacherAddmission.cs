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
    public partial class TeacherAddmission : Form
    {
        public TeacherAddmission()
        {
            InitializeComponent();
        }

        private void TeacherAddmission_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblJoininngDate_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string name = txtteacherName.Text;
            string qualification = txtQualifiction.Text;
            int salary =int.Parse( txtSal.Text);
            string date = dtTime.Value.ToString("yyyy-MM-dd");
            Teacher XYZ = new Teacher(name,qualification,salary,date);
            label3.Text = date;
           Connector.TeacherAdmission(XYZ.TeacherName, XYZ.Qualification,XYZ.Salary,XYZ.DateOfJoining);

        }
    }
}
