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
    public partial class ScoreForm : Form
    {
        private readonly SchoolFacade course, score, student;
        public ScoreForm()
        {
            InitializeComponent();
            course = SchoolFacade.Instance;
            score = SchoolFacade.Instance;
            student = SchoolFacade.Instance;
        }
        //Function to show data on score gridview
        private void ShowScore()
        {
            StudentDataView.DataSource = score.GetScoreList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId = student.StdId"));
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            //add course to combobox
            SelectCourseCB.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course`"));
            SelectCourseCB.DisplayMember = "CourseName";
            SelectCourseCB.ValueMember = "CourseName";

            //Display Student List
            StudentDataView.DataSource = student.GetStudentList(new MySqlCommand("SELECT `StdId`,`StdFirstName`,`StdLastName` FROM `student`"));
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StdIDTB.Text == "" || ScoreTB.Text == "")
            {
                MessageBox.Show("Need Score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdID = Convert.ToInt32(StdIDTB.Text);
                string cName = SelectCourseCB.Text;
                double sco = Convert.ToDouble(ScoreTB.Text);
                string desc = DescTB.Text;
                if (score.CheckScores(stdID, cName))
                {
                    if (score.InsertScores(stdID, cName, sco, desc))
                    {
                        ShowScore();
                        ClearBtn.PerformClick();
                        MessageBox.Show("New score added", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score not added", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The score for this course is already exsit", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            StdIDTB.Clear();
            ScoreTB.Clear();
            SelectCourseCB.SelectedIndex = 0;
            DescTB.Clear();
        }

        private void StudentDataView_Click(object sender, EventArgs e)
        {
            StdIDTB.Text = StudentDataView.CurrentRow.Cells[0].Value.ToString();
        }

        private void ShowStudentBtn_Click(object sender, EventArgs e)
        {
            StudentDataView.DataSource = student.GetStudentList(new MySqlCommand("SELECT `StdId`,`StdFirstName`,`StdLastName` FROM `student`"));
        }

        private void ShowScoreBtn_Click(object sender, EventArgs e)
        {
            ShowScore();
        }
    }
}
