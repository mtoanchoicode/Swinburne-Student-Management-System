using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ManageCourseForm : Form
    {
        private readonly SchoolFacade course;
        public ManageCourseForm()
        {
            InitializeComponent();
            course = SchoolFacade.Instance;
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        //Shiow data of the course
        private void showData()
        {
            //Show the course list
            CourseDataView.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CourseIDTB.Clear();
            CourseNameTB.Clear();
            HoursTB.Clear();
            DescTB.Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CourseNameTB.Text == "" || HoursTB.Text == "" || CourseIDTB.Text.Equals(""))
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(CourseIDTB.Text);
                string cName = CourseNameTB.Text;
                int hr = Convert.ToInt32(HoursTB.Text);
                string desc = DescTB.Text;
                if (course.UpdateCourses(id, cName, hr, desc))
                {
                    showData();
                    ClearBtn.PerformClick();
                    MessageBox.Show("Course update successful", "Update course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Course update fail", "Update course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CourseIDTB.Text.Equals(""))
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(CourseIDTB.Text);
                    if (course.DeleteCourses(id))
                    {
                        showData();
                        ClearBtn.PerformClick();
                        MessageBox.Show("Course deleted", "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CourseDataView_Click(object sender, EventArgs e)
        {
            CourseIDTB.Text = CourseDataView.CurrentRow.Cells[0].Value.ToString();
            CourseNameTB.Text = CourseDataView.CurrentRow.Cells[1].Value.ToString();
            HoursTB.Text = CourseDataView.CurrentRow.Cells[2].Value.ToString();
            DescTB.Text = CourseDataView.CurrentRow.Cells[3].Value.ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //Search for course
            CourseDataView.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`) LIKE '%" + searchTB.Text + "%'"));
            searchTB.Clear();
        }
    }
}
