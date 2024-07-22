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
    public partial class ManageScoreForm : Form
    {
        private readonly SchoolFacade course, score;
        public ManageScoreForm()
        {
            InitializeComponent();
            course = SchoolFacade.Instance;
            score = SchoolFacade.Instance;
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //add course to combobox
            SelectCourseCB.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course`"));
            SelectCourseCB.DisplayMember = "CourseName";
            SelectCourseCB.ValueMember = "CourseName";

            ShowScore();
        }
        public void ShowScore()
        {
            ScoreDataView.DataSource = score.GetScoreList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId = student.StdId"));
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (StdIDTB.Text == "" || ScoreTB.Text == "")
            {
                MessageBox.Show("Need Score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdID = Convert.ToInt32(StdIDTB.Text);
                string cName = SelectCourseCB.Text;
                double sco = Convert.ToInt32(ScoreTB.Text);
                string desc = DescTB.Text;

                if (score.UpdateScores(stdID, cName, sco, desc))
                {
                    ShowScore();
                    ClearBtn.PerformClick();
                    MessageBox.Show("Score editied", "Update score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Score fail to edit", "Update score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (StdIDTB.Text == "")
            {
                MessageBox.Show("Need student ID to delete", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(StdIDTB.Text);
                if (MessageBox.Show("Are you sure you want to delete this score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.DeleteScores(id))
                    {
                        ShowScore();
                        MessageBox.Show("Score Removed", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBtn.PerformClick();
                    }
                }
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            StdIDTB.Clear();
            ScoreTB.Clear();
            DescTB.Clear();
            searchTB.Clear();
        }

        private void ScoreDataView_Click(object sender, EventArgs e)
        {
            StdIDTB.Text = ScoreDataView.CurrentRow.Cells[0].Value.ToString();
            SelectCourseCB.Text = ScoreDataView.CurrentRow.Cells[3].Value.ToString();
            ScoreTB.Text = ScoreDataView.CurrentRow.Cells[4].Value.ToString();
            DescTB.Text = ScoreDataView.CurrentRow.Cells[5].Value.ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ScoreDataView.DataSource = score.GetScoreList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId = student.StdId WHERE CONCAT(student.StdFirstName, score.CourseName)LIKE '%"+searchTB.Text+"%'"));
        }
    }
}
