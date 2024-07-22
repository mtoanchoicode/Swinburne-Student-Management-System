using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.Devices;

namespace StudentManagementSystem
{
    public partial class StudentManageForm : Form
    {
        private readonly SchoolFacade student;
        public StudentManageForm()
        {
            InitializeComponent();
            student = SchoolFacade.Instance;
        }

        private void StudentManageForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        //Show student list
        public void showTable()
        {
            StudentDataView.DataSource = student.GetStudentList(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)StudentDataView.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        //Display student data from student to textbox
        private void StudentDataView_Click(object sender, EventArgs e)
        {
            IDTB.Text = StudentDataView.CurrentRow.Cells[0].Value.ToString();
            FNameTB.Text = StudentDataView.CurrentRow.Cells[1].Value.ToString();
            LNameTB.Text = StudentDataView.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)StudentDataView.CurrentRow.Cells[3].Value;
            if (StudentDataView.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                MaleRB.Checked = true;
            }
            PhoneTB.Text = StudentDataView.CurrentRow.Cells[5].Value.ToString();
            AddressTB.Text = StudentDataView.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])StudentDataView.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            studentPhoto.Image = Image.FromStream(ms);

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IDTB.Clear();
            FNameTB.Clear();
            LNameTB.Clear();
            PhoneTB.Clear();
            AddressTB.Clear();
            MaleRB.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            studentPhoto.Image = null;
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            //browse photo from local file
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                studentPhoto.Image = Image.FromFile(opf.FileName);
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            StudentDataView.DataSource = student.GetStudentList(new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`StdFirstName`, `StdLastName`, `Address`) LIKE'%"+ searchTB.Text +"%'"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)StudentDataView.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        //Verify Input
        private bool VerifyInput()
        {
            if (FNameTB.Text == "" || LNameTB.Text == "" || PhoneTB.Text == "" || AddressTB.Text == "" || studentPhoto.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //update student
            int id = Convert.ToInt32(IDTB.Text);
            string fname = FNameTB.Text;
            string lname = LNameTB.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = PhoneTB.Text;
            string address = AddressTB.Text;
            string gender = MaleRB.Checked ? "Male" : "Female";
            //Get photo
            MemoryStream ms = new MemoryStream();
            studentPhoto.Image.Save(ms, studentPhoto.Image.RawFormat);
            byte[] img = ms.ToArray();

            //Verify age
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (VerifyInput())
            {
                try
                {
                    if (student.UpdateStudents(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Student data update", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTB.Text);
            if (MessageBox.Show("Are you sure you want to remove this student", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.DeleteStudents(id))
                {
                    showTable();
                    MessageBox.Show("Student Removed", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBtn.PerformClick();
                }
            }
        }
    }
}
