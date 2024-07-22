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

namespace StudentManagementSystem
{
    public partial class RegisterForm : Form
    {
        private readonly SchoolFacade student;
        public RegisterForm()
        {
            InitializeComponent();
            student = SchoolFacade.Instance;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //add new student
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
                    if (student.InsertStudents(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FNameTB.Clear();
            LNameTB.Clear();
            PhoneTB.Clear();
            AddressTB.Clear();
            MaleRB.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            studentPhoto.Image = null;
        }
        //Show student list
        public void showTable()
        {
            StudentDataView.DataSource = student.GetStudentList(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)StudentDataView.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
