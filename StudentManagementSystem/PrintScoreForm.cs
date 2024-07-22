using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace StudentManagementSystem
{
    public partial class PrintScoreForm : Form
    {
        private readonly SchoolFacade score;
        DGVPrinter printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
            score = SchoolFacade.Instance;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ScoreDataView.DataSource = score.GetScoreList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId = student.StdId WHERE CONCAT(student.StdFirstName, score.CourseName)LIKE '%" + searchTB.Text + "%'"));
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //Using DGV printer to print pdf file
            printer.Title = "Swinburne Student Score table";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Swinburne Vietnam";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(ScoreDataView);
        }
        //Function to show score on data view
        public void ShowScore()
        {
            ScoreDataView.DataSource = score.GetScoreList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId = student.StdId"));
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            ShowScore();
        }
    }
}
