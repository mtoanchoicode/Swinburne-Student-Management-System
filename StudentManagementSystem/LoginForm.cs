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
    public partial class LoginForm : Form
    {
        private readonly SchoolFacade student;
        public LoginForm()
        {
            InitializeComponent();
            student = SchoolFacade.Instance;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.ForeColor = Color.LightGray;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text.Length == 0 || PasswordTB.Text.Length == 0)
            {
                MessageBox.Show("Please login", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string uname = usernameTB.Text;
                string pass = PasswordTB.Text;
                DataTable table = student.GetStudentList(new MySqlCommand("SELECT * FROM `user` WHERE `username` = '" + uname + "' AND `password` = '" + pass + "'"));
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    Form1 main = new Form1();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTB.Clear();
                    PasswordTB.Clear();
                }
            }
        }
    }
}
