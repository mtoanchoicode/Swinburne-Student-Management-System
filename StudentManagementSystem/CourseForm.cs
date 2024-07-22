using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;

namespace StudentManagementSystem
{
    public partial class CourseForm : Form
    {
        private readonly SchoolFacade course;
        public CourseForm()
        {
            InitializeComponent();
            course = SchoolFacade.Instance;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        //Function to show data
        private void showData()
        {
            //Show the course list
            CourseDataView.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            CourseNameTB.Clear();
            HoursTB.Clear();
            DescTB.Clear();
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (CourseNameTB.Text == "" || HoursTB.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = CourseNameTB.Text;
                int hr = Convert.ToInt32(HoursTB.Text);
                string desc = DescTB.Text;
                if (course.InsertCourses(cName, hr, desc))
                {
                    showData();
                    ClearBtn.PerformClick();
                    MessageBox.Show("New course inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course not insert", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
