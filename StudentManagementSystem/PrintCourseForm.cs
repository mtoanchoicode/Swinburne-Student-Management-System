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
using DGVPrinterHelper;

namespace StudentManagementSystem
{
    public partial class PrintCourseForm : Form
    {
        private readonly SchoolFacade course;
        DGVPrinter printer = new DGVPrinter();
        public PrintCourseForm()
        {
            InitializeComponent();
            course = SchoolFacade.Instance;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //Search for course
            CourseDataView.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`) LIKE '%" + searchTB.Text + "%'"));
            searchTB.Clear();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //Using DGV printer to print pdf file
            printer.Title = "Swinburne Course list";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Swinburne Vietnam";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(CourseDataView);
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            CourseDataView.DataSource = course.GetCourseList(new MySqlCommand("SELECT * FROM `course`"));
        }
    }
}
