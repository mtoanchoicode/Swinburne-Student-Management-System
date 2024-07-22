namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly SchoolFacade student;
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
            student = SchoolFacade.Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Display values
            StudentCount();
        }
        //Function for displaying student count
        private void StudentCount()
        {
            //Display values
            TotalStuLb.Text = "Total Students : " + student.TotalStudents();
            MaleStuLb.Text = "Male : " + student.MaleStudents();
            FemaleStuLb.Text = "Female : " + student.FemaleStudents();
        }
        private void CustomizeDesign()
        {
            StudentPanel.Visible = false;
            CoursePanel.Visible = false;
            GradePanel.Visible = false;

        }

        private void HideSubPanel()
        {
            if (StudentPanel.Visible == true)
            {
                StudentPanel.Visible = false;
            }
            if (CoursePanel.Visible == true)
            {
                CoursePanel.Visible = false;
            }
            if (GradePanel.Visible == true)
            {
                GradePanel.Visible = false;
            }
        }

        private void ShowSubPanel(Panel SubPanel)
        {
            if (SubPanel.Visible == false)
            {
                HideSubPanel();
                SubPanel.Visible = true;
            }
            else
            {
                SubPanel.Visible = false;
            }
        }
        //Sub panel Student

        private void StudentButton_Click(object sender, EventArgs e)
        {
            ShowSubPanel(StudentPanel);
        }

        private void StudentRegisBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            HideSubPanel();
        }

        private void ManageStudentBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentManageForm());
            HideSubPanel();
        }

        private void StudenPrintBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            HideSubPanel();
        }
        //Sub panel Course

        private void CourseButton_Click(object sender, EventArgs e)
        {
            ShowSubPanel(CoursePanel);
        }

        private void NewCourseBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            HideSubPanel();
        }

        private void ManageCourseBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            HideSubPanel();
        }

        private void CoursePrintBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            HideSubPanel();
        }
        //Sub panel Grade
        private void GradeButton_Click(object sender, EventArgs e)
        {
            ShowSubPanel(GradePanel);
        }

        private void NewGradeBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            HideSubPanel();
        }

        private void ManageGradeBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());
            HideSubPanel();
        }

        private void GradePrintBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            HideSubPanel();
        }

        //Show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void DashBoardBTn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            MainPanel.Controls.Add(CoverPanel);
            StudentCount();
        }
    }
}
