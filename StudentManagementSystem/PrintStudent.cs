using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;
using Microsoft.VisualBasic.Devices;

namespace StudentManagementSystem
{
    public partial class PrintStudent : Form
    {
        private readonly SchoolFacade student, course;
        DGVPrinter printer = new DGVPrinter();
        public PrintStudent()
        {
            InitializeComponent();
            student = SchoolFacade.Instance;
            course = SchoolFacade.Instance;
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            //add course to combobox
            ClassCB.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course`"));
            ClassCB.DisplayMember = "CourseName";
            ClassCB.ValueMember = "CourseName";
            showData(new MySqlCommand("SELECT * FROM `student`"));
        }
        //Function to show student list
        public void showData(MySqlCommand command)
        {
            StudentDataView.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            StudentDataView.DataSource = student.GetStudentList(command);
            // column of Image of student
            imageColumn = (DataGridViewImageColumn)StudentDataView.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //Check the radio button
            string selectQuery;
            if (AllRB.Checked)
            {
                selectQuery = "SELECT * FROM `student`";
            }
            else if (MaleRb.Checked)
            {
                selectQuery = "SELECT * FROM `student` WHERE `Gender` = 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM `student` WHERE `Gender` = 'Female'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //Using DGV printer to print pdf file
            printer.Title = "Swinburne Students list";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Swinburne Vietnam";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(StudentDataView);

        }

        private void ClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
